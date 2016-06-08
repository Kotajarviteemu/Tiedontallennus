using NorthwindWebapsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWebapsi.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            northwindEntities entities = new northwindEntities();
            List<Customers> model = entities.Customers.ToList();
            entities.Dispose();



            return View(model);
        }
        public ActionResult GetOrders(string id)
        {

            northwindEntities entities = new northwindEntities();
            List<Orders> orders = (from o in entities.Orders
                                   where o.CustomerID == id
                                   select o).ToList();
            entities.Dispose();

            List<SimpleOrderData> result = new List<SimpleOrderData>();
            foreach (Orders order in orders)

            {
                SimpleOrderData data = new SimpleOrderData();
                data.CustomerId = order.CustomerID;
                data.OrderId = order.OrderID;
                data.OrderDate = order.OrderDate.ToString();
                result.Add(data);

            }


            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}