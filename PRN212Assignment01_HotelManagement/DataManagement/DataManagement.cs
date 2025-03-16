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
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer { CustomerFullName = "Nguyen Van A", Telephone = "0123456789", EmailAddress = "A@gmail.com", Password = "123", CustomerStatus = 1, CustomerBirthday = new DateOnly() },
            new Customer { CustomerFullName = "Nguyen Van B", Telephone = "0123456789", EmailAddress = "B@gmail.com", Password = "123", CustomerStatus = 1, CustomerBirthday = new DateOnly() },
            new Customer { CustomerFullName = "Nguyen Van C", Telephone = "0123456789", EmailAddress = "C@gmail.com", Password = "123", CustomerStatus = 1, CustomerBirthday = new DateOnly() },
        };
        public static List<RoomType> RoomTypes = new List<RoomType>
        {
            new RoomType { RoomTypeID=1, RoomTypeName = "Single", TypeDescription = "1 bed", TypenNote = "Note" },
            new RoomType { RoomTypeID=2, RoomTypeName = "Double", TypeDescription = "2 beds", TypenNote = "Note" },
            new RoomType { RoomTypeID=3, RoomTypeName = "Triple", TypeDescription = "3 beds", TypenNote = "Note" },
        };
        public static List<RoomInformation> RoomInformations = new List<RoomInformation>
        {
            new RoomInformation { RoomID = Guid.NewGuid(), RoomNumber = "101", RoomDescription = "Room 101", RoomMaxCapacity = 1, RoomPricePerDate = 100, RoomTypeID = 1, RoomStatus = 1 },
            new RoomInformation { RoomID = Guid.NewGuid(), RoomNumber = "102", RoomDescription = "Room 102", RoomMaxCapacity = 2, RoomPricePerDate = 200, RoomTypeID = 2, RoomStatus = 1 },
            new RoomInformation { RoomID = Guid.NewGuid(), RoomNumber = "103", RoomDescription = "Room 103", RoomMaxCapacity = 3, RoomPricePerDate = 300, RoomTypeID = 3, RoomStatus = 1 },
        };
        public static List<Order> Orders = new List<Order>();

        public static Customer customer;
    }
}
