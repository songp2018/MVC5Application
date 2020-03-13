using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Application.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public String Index()//ActionResult-> string
        {
            return "Product from Index";//View()-> "Product"
        }

        // GET: Product/Browse
        public String Browse()//added
        {
            return "Browse displayed";
        }

        // GET: Product/Details/105
        public String Details(int id) //added
        {
            string message = "Details dilplayed for Id = " + id;
            return message;
        }

        // GET: Product/Location?zip=44124
        public String Location(int zip) //added
        {
            return "Location displayed for zip= "+ zip;
        }
    }
}