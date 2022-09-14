

using Microsoft.EntityFrameworkCore.Design;
using NorthwindWithLinq.Models;

Console.WriteLine("Northwind with LINQ");

    
NorthwindContext _context = new();









#region Grouping 3 Tables
////grouping 3 tables -by OrderId.  Orders, OrderDetails, & Products.
//var orderTotal = (from o in _context.Orders
//              join d in _context.OrderDetails
//                 on o.OrderId equals d.OrderId
//              join p in _context.Products
//                 on d.ProductId equals p.ProductId
//              group new { o, d, p } by o.OrderId into grp //group all 3 tables into grp variable
//              orderby grp.Key //grp.key like they are in dictionary.
//              select new
//              {
//                  OrderId = grp.Key,
//                  OrderTotal = grp.Sum(x => x.d.Quantity * x.p.UnitPrice)
//                  //sum into x, orderdetails quantity * products unit price
//              }).Sum(x => x.OrderTotal);
//Console.WriteLine($"Total all order is: {orderTotal:C}");
////foreach(var o in orders)
////{
////    Console.WriteLine($"{o.OrderId,5} | {o.LineTotal,12:C}");
////}
#endregion

#region Double Join 3 Tables
//double join for 3 tables, displaying companyname, productname, quantity & price
/*
var fred = from s in _context.Suppliers
           join p in _context.Products
            on s.SupplierId equals p.SupplierId
           join o in _context.OrderDetails
               on p.ProductId equals o.ProductId
           orderby s.CompanyName
           select new
           {
               Supplier = s.CompanyName,
               Product = p.ProductName,
               Quantity = o.Quantity,
               PricePer = o.UnitPrice,
               TotalPrice = o.UnitPrice * o.Quantity
           };
foreach(var s in fred)
{
    Console.WriteLine($"{s.Supplier, -40} | {s.Product,-35} | {s.Quantity, 5} | {s.PricePer, 10:C}");
}
Console.WriteLine($"Total Inventory cost {fred.Sum(s => s.TotalPrice):C}");
*/
#endregion

#region Lambda gets Everything
//gets everything
//_context.OrderDetails.ToList().ForEach(od => Console.WriteLine(od));
#endregion

#region Join 2 Tabls Print Co Name & Product
//joining the 2 tables and printing each company name with their product.
/*
var fred = from sup in _context.Suppliers
           join prod in _context.Products
            on sup.SupplierId equals prod.SupplierId
           orderby sup.CompanyName
           select new {
                Supplier = sup.CompanyName, 
                Product = prod.ProductName, 
                Price = prod.UnitPrice,
                Units = prod.UnitsInStock,
                InventoryCost = prod.UnitsInStock * prod.UnitPrice};
           

foreach(var s in fred)
{
    Console.WriteLine($"{s.Supplier,-40} | {s.Product,-35} | {s.InventoryCost,15:C}");
            //with alias it would be {s.Supplier} | {s.Product}.
}

Console.WriteLine($"Total Inventory Cost : {fred.Sum(s => s.InventoryCost),20:C}");
*/
#endregion

#region Calling methods other than ToString.
/*
Product product1 = new Product();  //had to call the Product class as new to use Product class methods.
var products = _context.Products.ToList();
    
    //instead of each individual column, this says to print the entire thing, unless ToString method is 
    //overridden in the class, then it prints the override information.
//products.ForEach(p => Console.WriteLine(p));

products.ForEach(product => Console.WriteLine(product.ProductIDName()));
*/
#endregion

#region Suppliers Table Code
//var suppliers = _context.Suppliers.ToList();
//suppliers.ForEach(s => Console.WriteLine(s));

//var employees = from empl in _context.Employees  //new var instance of context.table name
//                select empl;  //saying we want all columns by putting the alias
//
//foreach(Employee e in employees)
//{
//    Console.WriteLine($"{e.FirstName} {e.LastName}");
//}
#endregion

#region Employees not in USA using .ToUpper & .Equals chaining.
/*
Console.WriteLine("Employees not in USA");

var employeesAbroad = from empl in _context.Employees
                      where !empl.Country.ToUpper().Equals("USA".ToUpper())
                      //use the above to make all upper case incase they put usa. 
                      //where empl.Country != "USA"  --changed this to the above.
                      orderby empl.LastName
                      select empl;

foreach(Employee empAbroad in employeesAbroad)
{
    Console.WriteLine($"{empAbroad.FirstName} {empAbroad.LastName} | {empAbroad.Country}");
}
*/
#endregion








