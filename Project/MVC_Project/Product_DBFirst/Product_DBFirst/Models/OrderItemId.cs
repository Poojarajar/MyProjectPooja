using System;
using System.Collections.Generic;

namespace Product_DBFirst.Models;

public partial class OrderItemId
{
    public int OrderItemId1 { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int NoOfItems { get; set; }

    public virtual OrderTbl Order { get; set; } = null!;

    public virtual ProductTbl Product { get; set; } = null!;
}
