using PRN212Assignment01_HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN212Assignment01_HotelManagement.DataManagement
{
    public class DataManagement
    {
        public static List<Customer> Customers = new ();
        public static List<RoomType> RoomTypes = new List<RoomType>();
        public static List<RoomInformation> RoomInformations = new List<RoomInformation>();

        public static Customer customer;
    }
}
