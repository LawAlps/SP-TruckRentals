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
    /// Interaction logic for AddNewEmployee.xaml
    /// </summary>
    public partial class AddNewEmployee : Window
    {
        TruckEmployee emp;
        public AddNewEmployee(TruckEmployee emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            string name, address, telephone, officeAddress, phoneExt, username, password, role;
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

                name = nameTextBox.Text;
                address = addressTextBox.Text;
                telephone = telephoneTextBox.Text;
                officeAddress = officeAddressTextBox.Text;
                phoneExt = phoneExtTextBox.Text;
                username = usernameTextBox.Text;
                password = passwordTextBox.Text;
                role = roleComboBox.Text;

                // Creates Truck Person class object
                TruckPerson tp = new TruckPerson();
                tp.Name = name;
                tp.Address = address;
                tp.Telephone = telephone;

                // Creates Truck Employee object
                TruckEmployee te = new TruckEmployee();
                te.OfficeAddress = officeAddress;
                te.PhoneExtensionNumber = phoneExt;
                te.Username = username;
                te.Password = password;
                te.Role = role;

                // Link/Add Truck Person record with Truck Employee record
                te.Employee = tp;
                // Now Truck Employee object is ready to be sent to the database through Dataservice class inside DataAccessLayer

                DataService.AddNewEmployee(te);
                MessageBox.Show("Employee added successfully");

                nameTextBox.Clear();
                addressTextBox.Clear();
                telephoneTextBox.Clear();
                officeAddressTextBox.Clear();
                phoneExtTextBox.Clear();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
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
