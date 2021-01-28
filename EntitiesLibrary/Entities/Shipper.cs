using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiesLibrary.Entities
{
    public class Shipper
    {
        public int ShipperID { get; set; }

        public string ShipperName { get; set; }

        public string Phone { get; set; }

        // related entities

        public ICollection<Order> Orders { get; set; }
    }
}
