using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic
{
    public class LINQLogic : BaseLogic
    {
        public List<Customers> CustomersQuery()
        {
            var query1 = from customers in context.Customers
                         select customers;
            
            return query1.ToList();
        }

        public List<Products> ProductosSinStok()
        {
            var query2 = from productos in context.Products
                         where productos.UnitsInStock == 0
                         select productos;

            return query2.ToList();
        }

        public List<Products> ProductosStockPrecio3()
        {
            var query3 = from productos in context.Products
                         where productos.UnitsInStock > 0 && productos.UnitPrice > 3
                         select productos;

            return query3.ToList();
        }

        public List<Customers> RegionWa()
        {
            var query4 = context.Customers.Where(c => c.Region == "WA").ToList();

            return query4;
        }

        public Products ProductoID789()
        {
            var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789);

            return query5;
        }

        public List<Customers> NombresMayusMinus()
        {
            var query6 = from customers in context.Customers
                         select customers;

            return query6.ToList();
        
        }

        public List<Customers> ejercicio8()
        {

            var query8 = context.Customers.Where(c => c.Region == "WA").Take(3).ToList();

            return query8;

        }

        public List<Products> ejercicio9()
        {
            var query9 = context.Products.OrderBy(p => p.ProductName).ToList();

            return query9;
        }

        public List<Products> ejercicio10()
        {
            var query10 = from productos in context.Products
                          where productos.UnitsInStock > 0 
                          orderby productos.UnitsInStock descending
                          select productos;

            return query10.ToList();
        }

        public Products ejercicio12()
        {
            var query12 = context.Products.FirstOrDefault();

            return query12;
           
        }
    }
}
