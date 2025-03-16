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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
            tbFullname.Text = DataManagement.DataManagement.customer.CustomerFullName;
            tbEmail.Text = DataManagement.DataManagement.customer.EmailAddress;
            dpBirthdate.SelectedDate = ((DateOnly)DataManagement.DataManagement.customer.CustomerBirthday).ToDateTime(TimeOnly.MinValue);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataManagement.DataManagement.customer.CustomerFullName = tbFullname.Text;
            DataManagement.DataManagement.customer.EmailAddress = tbEmail.Text;
            DataManagement.DataManagement.customer.CustomerBirthday = DateOnly.FromDateTime(dpBirthdate.SelectedDate.Value.Date);
        }
    }
}
