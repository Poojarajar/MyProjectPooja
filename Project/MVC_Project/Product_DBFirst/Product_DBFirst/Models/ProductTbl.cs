using System;
using System.Collections.Generic;

namespace Product_DBFirst.Models;

public partial class ProductTbl
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public DateOnly? ProductDate { get; set; }

    public virtual ICollection<OrderItemId> OrderItemIds { get; set; } = new List<OrderItemId>();
}
