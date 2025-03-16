using Microsoft.Extensions.Configuration;
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

        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Set the base path for configuration file
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Load JSON file
            .Build();

        // Get a string from configuration
        string adminEmail = config["Admin:email"];
        string adminPassword = config["Admin:password"];


        if (email.Equals(adminEmail) && password.Equals(adminPassword))
        {
            MessageBox.Show("Login successfully");
            var adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }
        else
        {
            var customer = DataManagement.DataManagement.Customers.FirstOrDefault(c => c.EmailAddress.Equals(email) 
                                                                    && c.Password.Equals(password));
            if(customer != null)
            {
                DataManagement.DataManagement.customer = customer;
                CustomerWindow customerWindow = new CustomerWindow();
                customerWindow.Show();
                this.Close();
            }
            else MessageBox.Show("Login failed");
        }
    }
}