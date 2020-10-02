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

  }
}