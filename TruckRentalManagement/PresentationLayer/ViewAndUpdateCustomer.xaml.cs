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
    /// Interaction logic for ViewAndUpdateCustomer.xaml
    /// </summary>
    public partial class ViewAndUpdateCustomer : Window
    {
        TruckCustomer tc = null;
        TruckEmployee emp;
        public ViewAndUpdateCustomer(TruckEmployee emp)
        {
            this.emp = emp;
            InitializeComponent();
            searchPanel.Visibility = Visibility.Hidden;
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

        private void searchCustomerID_Click(object sender, RoutedEventArgs e)
        {
            int id;

            if (customerIDTextBox.Text == "")
            {
                MessageBox.Show("Please do not leave field empty.");
            }
            else
            {
                id = int.Parse(customerIDTextBox.Text);
                tc = DataService.searchCustomer(id);
            }

            if (tc == null)
            {
                MessageBox.Show("Please enter correct customer ID.");
            }
            else
            {
                nameTextBox.Text = tc.Customer.Name;
                addressTextBox.Text = tc.Customer.Address;
                telephoneTextBox.Text = tc.Customer.Telephone;
                licenseNumberTextBox.Text = tc.LicenseNumber;
                licenseExpiryDatePicker.SelectedDate = tc.LicenseExpiryDate;
                ageTextBox.Text = Convert.ToString(tc.Age);

                searchPanel.Visibility = Visibility.Visible;
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            int parsedValue;
            if (nameTextBox.Text.Length == 0 || addressTextBox.Text.Length == 0 || ageTextBox.Text.Length == 0 || licenseNumberTextBox.Text.Length == 0)
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

                tc.Customer.Name = nameTextBox.Text;
                tc.Customer.Address = addressTextBox.Text;
                tc.Customer.Telephone = telephoneTextBox.Text;
                tc.Age = int.Parse(ageTextBox.Text);
                tc.LicenseNumber = licenseNumberTextBox.Text;
                tc.LicenseExpiryDate = licenseExpiryDatePicker.SelectedDate.Value;

                DataService.updateCustomer(tc);
                MessageBox.Show("Employee info updated successfully");

                nameTextBox.Clear();
                addressTextBox.Clear();
                telephoneTextBox.Clear();
                licenseNumberTextBox.Clear();
                ageTextBox.Clear();
            }
        }
    }
}
