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
      //Arrange
      string info = "9 Cakes.";
      Order newOrder = new Order(info);

      //Act
      string updatedOrderInfo = "10 Cakes";
      newOrder.OrderInfo = updatedOrderInfo;
      string result = newOrder.OrderInfo;

      //Assert
      Assert.AreEqual(updatedOrderInfo, result);
    }


  }
}