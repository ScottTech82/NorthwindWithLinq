using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWithLinq.Models
{
    public class Order
    {
        public int OrderId { get; set; }  //PK
        public string? CustomerId { get; set; }  //FK to Customers Table
        public int? EmployeeId { get; set; }  //FK to Employees Table
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int? ShipVia { get; set; } //FK
        //7 other columns not yet added
    }
}
