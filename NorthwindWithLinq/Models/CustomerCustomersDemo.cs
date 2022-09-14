using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWithLinq.Models
{
    public class CustomerCustomersDemo
    {
        public string CustomerID { get; set; } //PK & FK to Customers
        public string CustomerTypeID { get; set; } //PK & FK to CustomerDemographics

    }
}
