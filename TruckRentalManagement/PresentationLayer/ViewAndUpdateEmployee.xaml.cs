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
    /// Interaction logic for ViewAndUpdateEmployee.xaml
    /// </summary>
    public partial class ViewAndUpdateEmployee : Window
    {
        TruckEmployee emp;

        TruckEmployee te = null;
        public ViewAndUpdateEmployee(TruckEmployee emp)
        {
            this.emp = emp;
            InitializeComponent();
            searchPanel.Visibility = Visibility.Hidden;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            if(emp.Role == "Administrator")
            {
            this.Hide();
            MainWindow form = new MainWindow(emp);
            form.ShowDialog();
            }
            else
            {
                if(emp.Role == "Staff")
                {
                    this.Hide();
                    MainWindowStaff form = new MainWindowStaff(emp);
                    form.ShowDialog();
                }
            }

        }

        private void searchCustomerID_Click(object sender, RoutedEventArgs e)
        {
            int id;

            if (employeeIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter correct employee ID");
            }
            else
            {
                id = int.Parse(employeeIDTextBox.Text);
                te = DataService.searchEmployee(id);
            }

            if (te == null)
            {
                MessageBox.Show("Please enter correct employee ID");
            }
            else
            {
                nameTextBox.Text = te.Employee.Name;
                addressTextBox.Text = te.Employee.Address;
                telephoneTextBox.Text = te.Employee.Telephone;
                officeAddressTextBox.Text = te.OfficeAddress;
                phoneExtTextBox.Text = te.PhoneExtensionNumber;
                usernameTextBox.Text = te.Username;
                passwordTextBox.Text = te.Password;
                roleComboBox.Text = te.Role;

                searchPanel.Visibility = Visibility.Visible;
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

                if (!int.TryParse(phoneExtTextBox.Text, out parsedValue))
                {
                    MessageBox.Show("Please only enter numbers in the telephone field.");
                    return;
                }

                te.Employee.Name = nameTextBox.Text;
                te.Employee.Address = addressTextBox.Text;
                te.Employee.Telephone = telephoneTextBox.Text;
                te.OfficeAddress = officeAddressTextBox.Text;
                te.PhoneExtensionNumber = phoneExtTextBox.Text;
                te.Username = usernameTextBox.Text;
                te.Password = passwordTextBox.Text;
                te.Role = roleComboBox.Text;

                DataService.updateEmployee(te);
                MessageBox.Show("Employee info updated successfully");

                nameTextBox.Clear();
                addressTextBox.Clear();
                telephoneTextBox.Clear();
                phoneExtTextBox.Clear();
                officeAddressTextBox.Clear();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }
    }
}
