using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ConsoleApp.Data.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {

            //Tüm müşteri kayıtlarını getiriniz


            // using (var db = new NothwindContext())
            // {
            //     var customers = db.Customers.ToList();

            //     foreach (var item in customers)
            //     {
            //         Console.WriteLine(item.FirstName + " " + item.LastName);
            //     }
            // }


            // Tüm müşteri kayıtlarının sadece first_name ve last_name alanlarını getiriniz.

            //  using (var db = new NothwindContext())
            // {
            //     var customers = db.Customers.Select(c=>new{
            //         c.FirstName,
            //         c.LastName
            //     });

            //     foreach (var item in customers)
            //     {
            //         Console.WriteLine(item.FirstName + " " + item.LastName);
            //     }
            // }


            // New York'da yaşayan müşterileri isim sırasına göre getiriniz.

            //  using (var db = new NothwindContext())
            // {
            //     var customers = db.Customers
            //     .Where(i=>i.City =="New York")
            //     .Select(s=>new{
            //         s.FirstName,
            //         s.LastName
            //     })
            //     .ToList();

            //      foreach (var item in customers)
            //     {
            //         Console.WriteLine(item.FirstName + " " + item.LastName);
            //     }


            //     }


            // Beverages kategorisine ait ürünlerin isimlerini getiriniz

            // using (var db = new NothwindContext())
            // {
            //     var products = db.Products
            //     .Where(i => i.Category == "Beverages")
            //     .Select(p =>p.ProductName)
            //     .ToList();

            //     foreach (var item in products)
            //     {
            //         Console.WriteLine(item);
            //     }


            // }


            // En son eklenen 5 ürün bilgisini alınız


            // using (var db = new NothwindContext())
            // {
            //     var products = db.Products.OrderByDescending(i=>i.Id).Take(5);


            //     foreach (var item in products)
            //     {
            //         Console.WriteLine(item.ProductName);
            //     }


            // }


            //Fiyatı 10 ile 30 arasında olan ürünlerin isim,fiyat bilgilerini azalan şekilde getiriniz.

            //  using (var db = new NothwindContext())
            // {
            //     var products = db.Products
            //     .Where(p=>p.ListPrice>10 && p.ListPrice<30)
            //     .Select(a=>new{
            //         a.ProductName,
            //         a.ListPrice
            //     })
            //     .ToList()
            //     .OrderByDescending(i=>i.ListPrice);


            //     foreach (var item in products)
            //     {
            //         Console.WriteLine($"Product_Name:{item.ProductName} ----- Product_Price:{item.ListPrice}");
            //     }


            // }


            //Beverages kategorisindeki ürünlerin ortalama fiyatı nedir?

            // using (var db = new NothwindContext())
            // {
            //     var productsOrtalama = db.Products
            //     .Where(c => c.Category == "Beverages")
            //     .Average(a => a.ListPrice);




            //     Console.WriteLine(productsOrtalama);


            // }


            //Beverages kategorisinde kaç ürün vardır ?

            //  using (var db = new NothwindContext())
            // {
            //     var productsCount = db.Products
            //     .Where(c => c.Category == "Beverages")
            //     .Count();




            //     Console.WriteLine(productsCount);



            // }


            //Beverages ve Condiments kategorilerindeki ürünlerin toplam fiyatı nedir?

            // using (var db = new NothwindContext())
            // {
            //     var products = db.Products
            //     .Where(c => c.Category == "Beverages" || c.Category == "Condiments")
            //     .Sum(i=>i.ListPrice);



            //     Console.WriteLine(products);



            // }


            //Tea kelimesi içeren ürünleri getiriniz.

            // using (var db = new NothwindContext())
            // {
            //     var products = db.Products
            //     .Where(i => i.ProductName.ToLower().Contains("tea"))
            //     .Select(a => a.ProductName)
            //     .ToList();

            //     foreach (var product in products)
            //     {
            //         Console.WriteLine($"İçinde Tea geçen ürünler:{product}");
            //     }






            // }

            //En pahalı ve ucuz ürün hangisidir?

            using (var db = new NothwindContext())
            {
                var minPrice = db.Products.Min(p => p.ListPrice);
                var maxPrice = db.Products.Max(p => p.ListPrice);

                var enPahali = db.Products
                .Where(a => a.ListPrice == db.Products.Max(p => p.ListPrice))
                .FirstOrDefault();

                var enUcuz = db.Products
               .Where(a => a.ListPrice == db.Products.Min(p => p.ListPrice))
               .FirstOrDefault();

                Console.WriteLine($"En Pahalı:{enPahali.ProductName}");
                Console.WriteLine($"En Ucuz:{enUcuz.ProductName}");




















            }









        }


    }
}

