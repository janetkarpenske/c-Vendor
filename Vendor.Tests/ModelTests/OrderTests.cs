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
      Order newOrder = new Order("testInfo", "testPrice");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetInfo_ReturnsInfoOnOrder_String()
    {
      //Arrange
      string info = "8 Croissants.";
      string price = "$12";

      //Act
      Order newOrder = new Order(info, price);
      string result = newOrder.OrderInfo;

      //Assert
      Assert.AreEqual(info, result);
    }
    
    [TestMethod]
    public void SetOrderInfo_SetOrderInfo_String()
    {
      string info = "9 Cakes.";
      string price = "$40.";
      Order newOrder = new Order(info, price);

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
      string price1 = "$10";
      string info2 = "10 Cakes";
      string price2 = "$20";
      Order newOrder1 = new Order(info1, price1);
      Order newOrder2 = new Order(info2, price2);
      List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAllOrders();
      CollectionAssert.AreEqual(newOrder, result);
    }

      [TestMethod]
    public void GetOrderId_OrdersAreCreatedWithAnId_Int()
    {
      string info = "3 Scones";
      string price = "$50";
      Order newOrder = new Order(info, price);

      int result = newOrder.OrderId;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindOrder_ReturnsTheCorrectOrder_Order()
    {
      //Arrange
      string info1 = "8 Cakes, 3 Brownies";
      string price1 = "$60";
      string info2 = "2 Scones";
      string price2 = "$20";
      Order newOrder1 = new Order(info1, price1);
      Order newOrder2 = new Order(info2, price2);

      //Act
      Order result = Order.FindOrder(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}