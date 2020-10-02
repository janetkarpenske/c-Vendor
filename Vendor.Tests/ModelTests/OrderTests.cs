using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vendor.Models;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfAnOrder_Order()
    {
      Order newOrder = new Order("testOrder");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetInfo_ReturnsInfoOnOrder_String()
    {
      //Arrange
      string info = "8 Croissants.";

      //Act
      Order newOrder = new Order(info);
      string result = newOrder.OrderInfo;

      //Assert
      Assert.AreEqual(info, result);
    }
    
    [TestMethod]
    public void SetOrderInfo_SetOrderInfo_String()
    {
      string info = "9 Cakes.";
      Order newOrder = new Order(info);

      string updatedOrderInfo = "10 Cakes";
      newOrder.OrderInfo = updatedOrderInfo;
      string result = newOrder.OrderInfo;
      Assert.AreEqual(updatedOrderInfo, result);
    }

        [TestMethod]
    public void GetAllOrders_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAllOrders();
      CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void GetAllOrders_ReturnsAllOrdersInList_OrderList()
    {
      string info1 = "8 Cakes";
      string info2 = "10 Cakes";
      Order newOrder1 = new Order(info1);
      Order newOrder2 = new Order(info2);
      List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAllOrders();
      CollectionAssert.AreEqual(newOrder, result);
    }

  }
}