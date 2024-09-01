using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_30_08
{
    internal class OrderService
    {

        public Product? GetProduct(int id)
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Products.FirstOrDefault(e => e.Id == id);
            }

        }


        public Orders? GetOrder(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Orders.FirstOrDefault(e => e.Id == id);
            }


        }

        public void AddOrder(Orders order)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }


        public void AddProduct(Product product)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void AddDataInProduct()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();


                List<Product> prodList = new List<Product>
                {
                    new Product{
                        Name = "Washing powder",
                        Price = 150,
                        
                    },

                    new Product{
                        Name = "Water",
                        Price = 90,
                        
                    },

                    new Product{
                        Name = "Bread",
                        Price = 15,
                        
                    }
                };

                db.Products.AddRange(prodList);
                db.SaveChanges();
            }
        }


        public void AddDataInOrders()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                


                List<Orders> orders = new List<Orders> {
                    new Orders {
                        DateTime = DateTime.Now,
                        Name = "Alex"
                        
                    },

                    new Orders{
                        DateTime = DateTime.Now,
                        Name = "Oleg"
                        
                    },

                    new Orders {
                        DateTime = DateTime.Now,
                        Name = "Ivan"
                    }
                };

                db.Orders.AddRangeAsync(orders);
                db.SaveChanges();
            }
        }


        public List<Orders> GetOrders()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                return db.Orders.ToList();
            }

        }
    }
}
