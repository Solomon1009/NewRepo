using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Demo2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //List<Product> products = new List<Product>()
            //{
            //    new Product()
            //    {
            //        Id = 1,
            //        Author = "David",
            //        Des = "Etiam luctus. Quisque facilisis suscipit elit. Curabitur...",
            //        Title = "Photography (by Best Author)",
            //        Image = "/Content/Theme_BookStore/images/templatemo_image_01.jpg",
            //        Price = 1100000
            //    },
            //    new Product()
            //    {
            //        Id = 2,
            //        Author = "Loc",
            //        Des = "Aliquam a dui, ac magna quis est eleifend dictum.",
            //        Title = "Cooking (by New Author)",
            //        Image = "/Content/Theme_BookStore/images/templatemo_image_02.jpg",
            //        Price = 1000000
            //    },
            //    new Product()
            //    {
            //        Id = 3,
            //        Author = "Phat",
            //        Des = "Ut fringilla enim sed turpis. Sed justo dolor, convallis at.",
            //        Title = "Gardening (by Famous Author)",
            //        Image = "/Content/Theme_BookStore/images/templatemo_image_03.jpg",
            //        Price = 90000
            //    },
            //    new Product()
            //    {
            //        Id = 4,
            //        Author = "Hung",
            //        Des = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            //        Title = "Sushi Book (by Japanese Name)",
            //        Image = "/Content/Theme_BookStore/images/templatemo_image_04.jpg",
            //        Price = 80000
            //    },
            //};

            //Application["ListProduct"] = products;
        }
    }
}
