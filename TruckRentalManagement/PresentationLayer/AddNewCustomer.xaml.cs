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
    /// Interaction logic for AddNewCustomer.xaml
    /// </summary>
    public partial class AddNewCustomer : Window
    {
        TruckEmployee emp;
        public AddNewCustomer(TruckEmployee emp)
        {
            this.emp = emp;
            InitializeComponent();
        }


        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            string name, address, telephone, licenseNumber;
            int age, parsedValue;
            DateTime licenseExpiryDate;

            if (nameTextBox.Text.Length == 0 || addressTextBox.Text.Length == 0 || telephoneTextBox.Text.Length == 0 || licenseNumberTextBox.Text.Length == 0 || ageTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter values first.");
            }
            else
            {

                if (int.TryParse(ageTextBox.Text, out age))
                {
                    if (age < 0)
                    {
                        MessageBox.Show("Please enter positive value for quantity.");
                    }
                    else
                    {
                        if (!int.TryParse(telephoneTextBox.Text, out parsedValue))
                        {
                            MessageBox.Show("Please only enter numbers in the telephone field.");
                            return;
                        }

                        if (!int.TryParse(licenseNumberTextBox.Text, out parsedValue))
                        {
                            MessageBox.Show("Please only enter numbers in the license number field.");
                            return;
                        }
                        name = nameTextBox.Text;
                        address = addressTextBox.Text;
                        telephone = telephoneTextBox.Text;
                        licenseNumber = licenseNumberTextBox.Text;
                        age = int.Parse(ageTextBox.Text);
                        licenseExpiryDate = licenseExpiryDatePicker.SelectedDate.Value;

                        // Creates Truck Person class object
                        TruckPerson tp = new TruckPerson();
                        tp.Name = name;
                        tp.Address = address;
                        tp.Telephone = telephone;

                        // Creates Truck Customer object
                        TruckCustomer tc = new TruckCustomer();
                        tc.LicenseNumber = licenseNumber;
                        tc.Age = age;
                        tc.LicenseExpiryDate = licenseExpiryDate;

                        // Link/Add Truck Person record with Truck Customer record
                        tc.Customer = tp;
                        // Now Truck Employee object is ready to be sent to the database through Dataservice class inside DataAccessLayer

                        // Send values to date service class function "AddNewProduct" to add to databse
                        DataService.AddNewCustomer(tc);
                        MessageBox.Show("Customer successfully added to database.");

                        // Clears text boxes to add more product(s)
                        nameTextBox.Clear();
                        addressTextBox.Clear();
                        telephoneTextBox.Clear();
                        licenseNumberTextBox.Clear();
                        ageTextBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter age as a number and not text");
                }
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
