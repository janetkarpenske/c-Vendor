using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string OrderInfo { get; set; }
    public int OrderId { get; }
    private static List<Order> _orderInstances = new List<Order> { };



    public static void ClearAll()
    {
      _orderInstances.Clear();
    }


  }
}
