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

    }

    public static void ClearAll()
    {
      _VendInstances.Clear();
    }

  }
}