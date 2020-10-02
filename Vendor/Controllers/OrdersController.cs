using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;

namespace Vendor.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")] //displays page that has a form to add a new order (to a vendor)
    public ActionResult New(int vendorId)
    {
      Vend vend = Vend.FindVend(vendorId);
      return View(vend);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")] //displays a specific order for a vendor
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindOrder(orderId);
      Vend vend = Vend.FindVend(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vend);
      return View(model);
    }
  }
}