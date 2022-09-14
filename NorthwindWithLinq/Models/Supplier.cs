using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWithLinq.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }

            //So I can just console write line s and return these results.  
            //instead of s.supplierid, etc.
        public override string ToString()
        {
            return $"SupplierID:   {SupplierId}\n" +
                   $"CompanyName:  {CompanyName}\n" +
                   $"ContactName:  {ContactName}\n" +
                   $"Phone #:      {Phone}\n";
        }

        public string SupplierIDName()
        {
            return $"SupplierID:   {SupplierId}\n" +
                   $"CompanyName:  {CompanyName}\n";

        }

    }
}
