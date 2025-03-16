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
    /// Interaction logic for CustomerHistoryOrder.xaml
    /// </summary>
    public partial class CustomerHistoryOrder : Window
    {
        List<Order> src = DataManagement.DataManagement.Orders;
        public CustomerHistoryOrder()
        {
            InitializeComponent();
            lvOrder.ItemsSource = src.Select(src => new
            {
                src.Customer.CustomerFullName,
                src.RoomInformation.RoomNumber,
                src.OrderDate
            }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            src = DataManagement.DataManagement.Orders.Where(o => o.RoomInformation.RoomNumber.Contains(tbRoomNumber.Text)).ToList();
            lvOrder.ItemsSource = src.Select(src => new
            {
                src.Customer.CustomerFullName,
                src.RoomInformation.RoomNumber,
                src.OrderDate
            }).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            src = DataManagement.DataManagement.Orders;
            lvOrder.ItemsSource = src.Select(src => new
            {
                src.Customer.CustomerFullName,
                src.RoomInformation.RoomNumber,
                src.OrderDate
            }).ToList();
        }
    }
}
