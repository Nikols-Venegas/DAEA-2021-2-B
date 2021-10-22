using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Origen de datos
            NorthwndDataContext context = new NorthwndDataContext();


            //Creación de consulta

            /* Listar */
            //var query = from p in context.Products
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name ={1}", prod.ProductID, prod.ProductName);
            //}

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name ={1}", prod.ProductID, prod.ProductName);
            //}

            //var query = from p in context.Products
            //            where p.UnitPrice < 20
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name ={2}", prod.ProductID, prod.UnitPrice,prod.ProductName);
            //}

            //var query = from p in context.Products
            //            where p.ProductName.Contains("queso")
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name ={1}", prod.ProductID, prod.ProductName);
            //}

            //var query = from p in context.Products
            //            where p.QuantityPerUnit.Contains("pkg")
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Nombre={1} \t Presentacion={2}", prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            //}

            //var query = from p in context.Products
            //            where p.ProductName.StartsWith("A")
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("Nombre={0} \t Precio={1}", prod.ProductName, prod.UnitPrice);
            //}

            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //}

            //var query = from p in context.Products
            //            where p.Discontinued == true
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //}
            //Console.ReadKey();

            /* Insertando */
            //Products p = new Products();
            //p.ProductName = "Peruvian Coffee";
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;
            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();

            //Categories c = new Categories();
            //c.CategoryName = "Drinks";
            //c.CategoryID = 9;
            //c.Description = "Sodas, mineral water and juices";
            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();

            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //               select p).FirstOrDefault();
            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;
            //context.SubmitChanges();

            //var product = (from p in context.Products
            //               where p.ProductID == 78
            //               select p).FirstOrDefault();
            //context.Products.DeleteOnSubmit(product);
            //context.SubmitChanges();


            /* tarea */
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Dairy Products"
            //            select p;
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Nombre Producto={1} \t Nombre Provedor={2}", prod.ProductID, prod.ProductName, prod.Suppliers.CompanyName);
            //}

            var query = from p in context.Products
                        where p.Suppliers.Country == "USA"
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Nombre={1} \t  Precio={2} \t Stock={3}", prod.ProductID, prod.ProductName, prod.UnitPrice, prod.UnitsInStock);
            }
            Console.ReadKey();
        }
    }
}
