using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string OrderInfo { get; set; }
    public string OrderPrice { get; set; }
    public int OrderId { get; }
    private static List<Order> _orderInstances = new List<Order> { };

    public Order(string orderInfo, string orderPrice)
    {
      OrderInfo = orderInfo;
      OrderPrice = orderPrice;
      _orderInstances.Add(this);
      OrderId = _orderInstances.Count;
    }

    public static List<Order> GetAllOrders()
    {
      return _orderInstances;
    }

  public static Order FindOrder(int SearchId)
  {
    return _orderInstances[SearchId - 1];
  }
    public static void ClearAll()
    {
      _orderInstances.Clear();
    }


  }
}
