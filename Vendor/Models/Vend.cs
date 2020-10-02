using System.Collections.Generic;

namespace Vendor.Models
{
  public class Vend
  {
    private static List<Vend> _VendInstances = new List<Vend> { };
    public string VendName { get; set; }
    public int VendId { get; }
    public List<Order> Orders { get; set; }

    public Vend(string vendName)
    {
      VendName = vendName;
      _VendInstances.Add(this);
      VendId = _VendInstances.Count;
      Orders = new List<Order> { };
    }

    public static List<Vend> GetAllVends()
    {
      return _VendInstances;
    }

    public static void ClearAll()
    {
      _VendInstances.Clear();
    }

  }
}