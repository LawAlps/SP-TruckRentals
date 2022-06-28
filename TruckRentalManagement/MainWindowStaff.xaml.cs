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
using TruckRentalManagement.DataAccessLayer.DB;

namespace TruckRentalManagement
{
    /// <summary>
    /// Interaction logic for MainWindowStaff.xaml
    /// </summary>
    public partial class MainWindowStaff : Window
    {
        TruckEmployee emp;
        public MainWindowStaff(TruckEmployee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            PresentationLayer.LoginForm form = new PresentationLayer.LoginForm();
            form.Show();
            this.Close();
        }

        private void addNewEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PresentationLayer.AddNewEmployee form = new PresentationLayer.AddNewEmployee(emp);
            form.ShowDialog();
        }

        private void addNewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PresentationLayer.AddNewCustomer form = new PresentationLayer.AddNewCustomer(emp);
            form.ShowDialog();
        }

        private void viewAndUpdateCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PresentationLayer.ViewAndUpdateCustomer form = new PresentationLayer.ViewAndUpdateCustomer(emp);
            form.ShowDialog();
        }

        private void viewAndUpdateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PresentationLayer.ViewAndUpdateEmployee form = new PresentationLayer.ViewAndUpdateEmployee(emp);
            form.ShowDialog();
        }

        private void viewAndUpdateInfoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PresentationLayer.ViewAndUpdateUser form = new PresentationLayer.ViewAndUpdateUser(emp);
            form.ShowDialog();
        }

        private void addNewTruckButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void displayAvailableTrucksButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void viewAndUpdateTruckInfoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rentTruckButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void returnTruckButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void displayListCustomerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void displayTruckSoldsDateButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
