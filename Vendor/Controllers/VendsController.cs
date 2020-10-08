using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace Vendor.Controllers
{
  public class VendsController : Controller
  {
    [HttpGet("/vendors")] //displays the page that shows a list of all the vendors
    public ActionResult Index()
    {
      List<Vend> allVendors = Vend.GetAllVends();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")] //displays the page that has the form to create a new Vendor
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")] //adds the created vendor from the form.
    public ActionResult Create(string vendName)
    {
      Vend newVend = new Vend(vendName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendId}")] //shows all orders for a specific vendor
    public ActionResult Show(int vendId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vend selectedVend = Vend.FindVend(vendId);
      List<Order> allVendOrders = selectedVend.Orders;
      model.Add("vendor", selectedVend);
      model.Add("orders", allVendOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")] //Creates new order within a Vendor
    public ActionResult Create(int vendorId, string OrderInfo, string OrderPrice, string OrderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vend foundVend = Vend.FindVend(vendorId);
      Order newOrder = new Order(OrderInfo, OrderPrice, OrderDate);
      foundVend.AddOrder(newOrder);
      List<Order> allVendOrders = foundVend.Orders;
      model.Add("orders", allVendOrders);
      model.Add("vendor", foundVend);
      return View("Show", model);
    }
  }
}