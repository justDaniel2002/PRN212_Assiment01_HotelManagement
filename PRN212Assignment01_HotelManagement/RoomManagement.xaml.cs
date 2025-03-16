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
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        RoomInformation selectedRoom;
        public RoomManagement()
        {
            InitializeComponent();
            lvRoom.ItemsSource = DataManagement.DataManagement.RoomInformations;
            cbRoomtype.ItemsSource = DataManagement.DataManagement.RoomTypes;
            cbRoomtype.DisplayMemberPath = "RoomTypeName";
        }

        private void lvRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedRoom = (RoomInformation)lvRoom.SelectedItem;
            
            if (selectedRoom != null)
            {
                tbRoomNumber.Text = selectedRoom.RoomNumber;
                tbCapacity.Text = selectedRoom.RoomMaxCapacity.ToString();
                tbDescription.Text = selectedRoom.RoomDescription;
                tbPrice.Text = selectedRoom.RoomPricePerDate.ToString();
                cbRoomtype.SelectedItem = DataManagement.DataManagement.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == selectedRoom.RoomTypeID);
            }
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(tbRoomNumber.Text == "" || tbCapacity.Text == "" || tbDescription.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            var room = new RoomInformation
            {
                RoomID = Guid.NewGuid(),
                RoomNumber = tbRoomNumber.Text,
                RoomDescription = tbDescription.Text,
                RoomMaxCapacity = int.Parse(tbCapacity.Text),
                RoomPricePerDate = decimal.Parse(tbPrice.Text),
            };

            DataManagement.DataManagement.RoomInformations.Add(room);

            MessageBox.Show("Add room successfully");
            lvRoom.ItemsSource = null;
            lvRoom.ItemsSource = DataManagement.DataManagement.RoomInformations;

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (tbRoomNumber.Text == "" || tbCapacity.Text == "" || tbDescription.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            if(selectedRoom == null)
            {
                MessageBox.Show("Please select a room to edit");
                return;
            }

            selectedRoom.RoomNumber = tbRoomNumber.Text;
            selectedRoom.RoomDescription = tbDescription.Text;
            selectedRoom.RoomMaxCapacity = int.Parse(tbCapacity.Text);
            selectedRoom.RoomPricePerDate = decimal.Parse(tbPrice.Text);

            foreach(var item in DataManagement.DataManagement.RoomInformations)
            {
                if (item.RoomID == selectedRoom.RoomID)
                {
                    item.RoomNumber = selectedRoom.RoomNumber;
                    item.RoomDescription = selectedRoom.RoomDescription;
                    item.RoomMaxCapacity = selectedRoom.RoomMaxCapacity;
                    item.RoomPricePerDate = selectedRoom.RoomPricePerDate;
                }
            }

            MessageBox.Show("Edit room successfully");

            lvRoom.ItemsSource = null;
            lvRoom.ItemsSource = DataManagement.DataManagement.RoomInformations;

        }

        private void btnChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room to edit");
                return;
            }

            foreach (var item in DataManagement.DataManagement.RoomInformations)
            {
                if (item.RoomID == selectedRoom.RoomID)
                {
                    item.RoomStatus = item.RoomStatus == 1 ? 2 : 1;
                }
            }
            lvRoom.ItemsSource = null;
            lvRoom.ItemsSource = DataManagement.DataManagement.RoomInformations;

        }
    }
}
