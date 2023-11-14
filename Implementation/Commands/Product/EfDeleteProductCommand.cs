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
    public class EfDeleteProductCommand : IDeleteProductCommand
    {
        public int Id => 0;

        public string Name => "Delete Product";

        public string Description => "Delete Product Using EF Framework.";

        private readonly WebShopContext _context;

        public EfDeleteProductCommand(WebShopContext context)
        {
            _context = context;
        }
        public void Execute(DeleteProductDTO request)
        {
            var product = _context.Products.Find(request.Id);
            if (product == null)
            {
                throw new Exception("Product not found!");
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
