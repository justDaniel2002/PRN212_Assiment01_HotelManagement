using PRN212Assignment01_HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRN212Assignment01_HotelManagement
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        Customer selectedCustomer;
        public CustomerManagement()
        {
            InitializeComponent();
            lvCus.ItemsSource = DataManagement.DataManagement.Customers;
            cbCus.ItemsSource = DataManagement.DataManagement.Customers;
            cbCus.DisplayMemberPath = "CustomerFullName";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }

            foreach (var item in DataManagement.DataManagement.Customers)
            {
                if (item.CustomerFullName.Equals(selectedCustomer.CustomerFullName))
                {
                    item.CustomerStatus = item.CustomerStatus==1?2:1;
                }
                
            }
            lvCus.ItemsSource = null;
            cbCus.ItemsSource = null;
            lvCus.ItemsSource = DataManagement.DataManagement.Customers;
            cbCus.ItemsSource = DataManagement.DataManagement.Customers;
        }

        private void cbCus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCustomer = cbCus.SelectedItem as Customer;
        }
    }
}
