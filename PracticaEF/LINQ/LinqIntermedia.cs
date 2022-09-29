using PracticasBF.Logic;
using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LinqIntermedia : LINQLogic 
    {
        LINQLogic linq = new LINQLogic();
        public void Ejercicio1()
        {
            foreach (Customers customers in linq.CustomersQuery())
            {
                Console.WriteLine($"{customers.CustomerID} - {customers.CompanyName} - {customers.ContactName} - " +
                                  $"{customers.ContactTitle} - {customers.Address} - {customers.City} - {customers.Region}" +
                                  $" - {customers.PostalCode} - {customers.Country} - {customers.Phone} - {customers.Fax}");
            }
        }

        public void Ejercicio2()
        {
            foreach (var item in linq.ProductosSinStok())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName}");
            }
        }

        public void Ejercicio3()
        {
            foreach (var item in linq.ProductosStockPrecio3())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitsInStock}");
            }
        }

        public void Ejercicio4()
        {
            foreach (var item in linq.RegionWa())
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName} - {item.Region}");
            }
        }

        public void Ejercicio5()
        {
            if (linq.ProductoID789() == null)
            {
                Console.WriteLine("null");
            }
        }

        public void Ejercicio6()
        {
            foreach (var item in linq.NombresMayusMinus())
            {
                Console.WriteLine($"{item.CompanyName.ToUpper()} - {item.CompanyName.ToLower()}");
            }
        }

        public void Ejercicio7()
        {
            var query7 = from customers in context.Customers
                         join orders in context.Orders on
                         customers.CustomerID equals orders.CustomerID
                         where customers.Region == "WA" && orders.OrderDate > new DateTime(1997 / 1 / 1)
                         orderby orders.OrderDate
                         select new { customers, orders };

            foreach (var item in query7)
            {
                Console.WriteLine($"{item.customers.CompanyName} - {item.customers.Region}" +
                                  $" - {item.orders.OrderID} - {item.orders.OrderDate}");
            }
        }

        public void Ejercicio8()
        {
            foreach (var item in linq.ejercicio8())
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName} - {item.Region}");
            }
        }

        public void Ejercicio9()
        {
            foreach (var item in linq.ejercicio9())
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }

        public void Ejercicio10()
        {
            foreach (var item in linq.ejercicio10())
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            }
        }

        public void Ejercicio11()
        {
            var query11 = from categories in context.Categories
                          join producs in context.Products on
                          categories.CategoryID equals producs.CategoryID
                          orderby categories.CategoryID ascending
                          select new { categories, producs };

            foreach (var item in query11)
            {
                Console.WriteLine($"{item.categories.CategoryID} - {item.categories.CategoryName} -" +
                                  $" {item.producs.CategoryID} - {item.producs.ProductName}");
            }

        }

        public void Ejercicio12()
        {
            Console.WriteLine(linq.ejercicio12().ProductName);
        }

        public void Ejercicio13()
        {
            var query13 = from customers in context.Customers
                          join orders in context.Orders on
                          customers.CustomerID equals orders.CustomerID
                          orderby customers.CustomerID
                          select new { customers, orders};

            foreach (var item in query13)
            {
                Console.WriteLine($"{item.customers.CustomerID} - {item.customers.CompanyName} - {item.orders.OrderID}");
            }
        }
    }
}
