using Application.DTO;
using Application.UseCases.Commands.Cart;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Cart
{
    public class EfDeleteCartCommand : IDeleteCartCommand
    {
        public int Id => 0;

        public string Name => "Delete Cart";

        public string Description => "Delete Cart Using EF Framework.";

        private readonly WebShopContext _context;

        public EfDeleteCartCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(DeleteCartDTO request)
        {
            var cart = _context.Carts.Find(request.Id);
            if (cart == null) 
            {
                throw new Exception("Cart not found!");
            }

            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }
    }
}
