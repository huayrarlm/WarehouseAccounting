using System;
using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    public class User
    {
        public Guid id { get; set; }    
        public string name { get; set; }         
        public string email { get; set; }         
        public string password { get; set; }      
        public string role { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<History> History { get; set; }

        public User()
        {
            Orders = new List<Order>();
            Shipments = new List<Shipment>();
            History = new List<History>();
        }
    }
}