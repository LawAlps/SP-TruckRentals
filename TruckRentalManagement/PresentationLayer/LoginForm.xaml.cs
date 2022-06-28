using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TruckRentalManagement.DataAccessLayer;
using TruckRentalManagement.DataAccessLayer.DB;

namespace TruckRentalManagement.PresentationLayer
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (userNameTextBox.Text.Length == 0 || passwordBox.Password.Length == 0)
            {
                MessageBox.Show("Please enter login details.");
            }
            else
            {
                TruckEmployee user = DataService.Login(userNameTextBox.Text, passwordBox.Password);

                if (user == null)
                {
                    MessageBox.Show("Sorry, user not found.");
                }
                else
                {
                    MessageBox.Show("Welcome, " + user.Username + ". Role: " + user.Role + ".");

                    if (user.Role == "Administrator")
                    {
                        MainWindow form = new MainWindow(user);
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        if (user.Role == "Staff")
                        {
                            MainWindowStaff form = new MainWindowStaff(user);
                            form.Show();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
