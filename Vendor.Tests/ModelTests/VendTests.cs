using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vendor.Models;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class VendTest : IDisposable
  {

    public void Dispose()
    {
      Vend.ClearAll();
    }
        [TestMethod]
    public void VendConstructor_CreatesInstanceOfAVendor_Vend()
    {
      Vend newVend = new Vend("test vendor");
      Assert.AreEqual(typeof(Vend), newVend.GetType());
    }
        [TestMethod]
    public void GetVendName_ReturnsVendName_String()
    {
      string vendName = "Suzie's Cupcakes";
      Vend newVend = new Vend(vendName);

      string result = newVend.VendName;
      Assert.AreEqual(vendName, result);
    }
        [TestMethod]
    public void GetVendId_ReturnsVendId_Int()
    {
      string VendName = "Test Vendor";
      Vend newVend = new Vend(VendName);

      int result = newVend.VendId;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAllVends_ReturnsTheListOfAllVends_VendList()
    {
      string name1 = "Suzie's Cupcakes";
      string name2 = "David's Donut Shop";
      Vend newVend1 = new Vend(name1);
      Vend newVend2 = new Vend(name2);
      List<Vend> newVendList = new List<Vend> { newVend1, newVend2 };

      List<Vend> result = Vend.GetAllVends();
      CollectionAssert.AreEqual(newVendList, result);
    }

    [TestMethod]
    public void FindVend_ReturnsASpecificVendor_Vend()
    {
      string name1 = "Suzie's Cupcakes";
      string name2 = "David's Donut Shop";
      Vend newVend1 = new Vend(name1);
      Vend newVend2 = new Vend(name2);

      Vend result = Vend.FindVend(2);
      Assert.AreEqual(newVend2, result);
    }
  }
}