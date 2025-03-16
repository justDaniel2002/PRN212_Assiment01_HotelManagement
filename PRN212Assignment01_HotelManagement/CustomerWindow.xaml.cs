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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        RoomInformation selectedRoom;
        public CustomerWindow()
        {
            InitializeComponent();
            cbRomNumber.ItemsSource = DataManagement.DataManagement.RoomInformations;
            cbRomNumber.DisplayMemberPath = "RoomNumber";
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            DataManagement.DataManagement.customer = null;
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void cbRomNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedRoom = cbRomNumber.SelectedItem as RoomInformation;
            tbCapacity.Text = selectedRoom.RoomMaxCapacity.ToString();
            tbPrice.Text = selectedRoom.RoomPricePerDate.ToString();
            tbDescription.Text = selectedRoom.RoomDescription;
            var roomtype = DataManagement.DataManagement.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == selectedRoom.RoomTypeID);
            tbRoomType.Text = roomtype.RoomTypeName;
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if(selectedRoom == null)
            {
                MessageBox.Show("Please select a room");
                return;
            }

            DataManagement.DataManagement.Orders.Add(new Order
            {
                Customer = DataManagement.DataManagement.customer,
                RoomInformation = selectedRoom,
                OrderDate = DateTime.Now
            });

            MessageBox.Show("Order successfully");

            var orderhistory = new CustomerHistoryOrder();
            orderhistory.Show();
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            var profile = new Profile();
            profile.Show();
        }
    }
}
