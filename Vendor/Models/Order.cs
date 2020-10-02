using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string OrderInfo { get; set; }
    public int OrderId { get; }
    private static List<Order> _orderInstances = new List<Order> { };

    public Order(string orderInfo)
    {
      OrderInfo = orderInfo;
      _orderInstances.Add(this);
      OrderId = _orderInstances.Count;
    }

    public static List<Order> GetAllOrders()
    {
      return _orderInstances;
    }


    public static void ClearAll()
    {
      _orderInstances.Clear();
    }


  }
}
