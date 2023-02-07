using System;
using System.Collections.Generic;

namespace HW_Warehouse_EF_WinFormsApp.Entities;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; } = new List<Delivery>();
}
