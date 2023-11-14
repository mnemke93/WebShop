using Application.DTO;
using Application.UseCases.Commands.Product;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Product
{
    public class EfAddProductCommand : IAddProductCommand
    {
        public int Id => 0;

        public string Name => "Add Product";

        public string Description => "Add Product Using EF Framework";

        private readonly WebShopContext _context;

        public EfAddProductCommand(WebShopContext context)
        {
            _context = context;
        }
        public void Execute(AddProductDTO request)
        {
            var product = new Domain.Entities.Product
            {
                ProductName = request.ProductName,
                ProductDescription = request.ProductDescription,
                Quantity = request.Quantity,
                Price = request.Price,
                CategoryID = request.CategoryID,
                SupplierID = request.SupplierID,
            };

            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
