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
    public class EfUpdateProductCommand : IUpdateProductCommand
    {
        public int Id => 0;

        public string Name => "Update Product";

        public string Description => "Update Product Using EF Framework";

        private readonly WebShopContext _context;

        public EfUpdateProductCommand(WebShopContext context)
        {
            _context = context;
        }
        public void Execute(UpdateProductDTO request)
        {
            var product = _context.Products.Find(request.Id);

            if (product == null)
            {
                throw new Exception("Product not found!");
            }

            product.ProductName = request.ProductName;
            product.ProductDescription = request.ProductDescription;
            product.Quantity = request.Quantity;
            product.Price = request.Price;
            product.CategoryID = request.CategoryID;
            product.SupplierID = request.SupplierID;

            _context.SaveChanges();
        }
    }
}
