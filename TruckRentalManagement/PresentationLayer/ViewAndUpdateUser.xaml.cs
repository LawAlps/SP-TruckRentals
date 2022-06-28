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
    /// Interaction logic for ViewAndUpdateUser.xaml
    /// </summary>
    public partial class ViewAndUpdateUser : Window
    {
        TruckEmployee emp;
        public ViewAndUpdateUser(TruckEmployee emp)
        {
            InitializeComponent();
            emp = DataService.searchEmployee(emp.EmployeeId);
            this.emp = emp;

            nameTextBox.Text = emp.Employee.Name;
            addressTextBox.Text = emp.Employee.Address;
            telephoneTextBox.Text = emp.Employee.Telephone;
            officeAddressTextBox.Text = emp.OfficeAddress;
            phoneExtTextBox.Text = emp.PhoneExtensionNumber;
            usernameTextBox.Text = emp.Username;
            passwordTextBox.Text = emp.Password;
            roleComboBox.Text = emp.Role;

            if (emp.Role == "Staff")
            {
                roleComboBox.IsEnabled = false;
                officeAddressTextBox.IsEnabled = false;
            }
        }


        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            int parsedValue;
            if (nameTextBox.Text.Length == 0 || addressTextBox.Text.Length == 0 || telephoneTextBox.Text.Length == 0 || officeAddressTextBox.Text.Length == 0 || phoneExtTextBox.Text.Length == 0 || usernameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter values first.");
            }
            else
            {
                if (!int.TryParse(telephoneTextBox.Text, out parsedValue))
                {
                    MessageBox.Show("Please only enter numbers in the telephone field.");
                    return;
                }

            emp.Employee.Name = nameTextBox.Text;
            emp.Employee.Address = addressTextBox.Text;
            emp.Employee.Telephone = telephoneTextBox.Text;
            emp.OfficeAddress = officeAddressTextBox.Text;
            emp.PhoneExtensionNumber = phoneExtTextBox.Text;
            emp.Username = usernameTextBox.Text;
            emp.Password = passwordTextBox.Text;
            emp.Role = roleComboBox.Text;

            DataService.updateEmployee(emp);
            MessageBox.Show("Your details have successfully been updated!");
            }
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            if (emp.Role == "Administrator")
            {
                this.Hide();
                MainWindow form = new MainWindow(emp);
                form.ShowDialog();
            }
            else
            {
                if (emp.Role == "Staff")
                {
                    this.Hide();
                    MainWindowStaff form = new MainWindowStaff(emp);
                    form.ShowDialog();
                }
            }
        }
    }
}
