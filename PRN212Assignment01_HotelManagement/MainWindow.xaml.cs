using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN212Assignment01_HotelManagement;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var email = tbEmail.Text;
        var password = tbPassword.Password;

        if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter email and password");
            return;
        }

        if(email == "admin" && password == "admin")
        {
            MessageBox.Show("Login successfully");
            /*var adminWindow = new AdminWindow();
            adminWindow.Show();*/
            this.Close();
        }
        else
        {
            var customer = DataManagement.DataManagement.Customers.FirstOrDefault(c => c.EmailAddress.Equals(email) 
                                                                    && c.Password.Equals(password));
            if(customer != null)
            {
                DataManagement.DataManagement.customer = customer;
            }
            else MessageBox.Show("Login failed");
        }
    }
}