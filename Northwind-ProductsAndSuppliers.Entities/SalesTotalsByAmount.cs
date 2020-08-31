using System;
using System.Collections.Generic;

namespace Northwind_ProductsAndSuppliers.Entities
{
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
