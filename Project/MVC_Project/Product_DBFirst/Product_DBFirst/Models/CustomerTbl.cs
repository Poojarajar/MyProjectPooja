using System;
using System.Collections.Generic;

namespace Product_DBFirst.Models;

public partial class CustomerTbl
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public long CustomerContact { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<OrderTbl> OrderTbls { get; set; } = new List<OrderTbl>();
}
