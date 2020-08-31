using Microsoft.EntityFrameworkCore;

using Northwind_ProductsAndSuppliers.Entities;

using System.Collections.Generic;
using System.Linq;

namespace Northwind_ProductsAndSuppliers.DataAccess
{
    public class ProductRepository : RepositoryBase<Product>
    {
        protected const string supplier = "Supplier";

        public override Product GetBy(int id)
        {
            return context.Products
                .Include(supplier)
                .SingleOrDefault(p => p.ProductId == id);
        }

        public override IEnumerable<Product> GetAll()
        {
            return context.Products.Include(supplier);
        }
    }
}
