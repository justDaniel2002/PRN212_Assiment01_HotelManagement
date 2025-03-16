using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN212Assignment01_HotelManagement.Models
{
    public class Order
    {
        public DateTime? OrderDate { get; set; }
        public RoomInformation? RoomInformation { get; set; }
        public Customer? Customer { get; set; }
    }
}
