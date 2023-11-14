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
    public class EfUpdateCartCommand : IUpdateCartCommand
    {
        public int Id => 0;

        public string Name => "Update Cart";

        public string Description => "Update Cart Using EF Framework.";

        private readonly WebShopContext _context;

        public EfUpdateCartCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(UpdateCartDTO request)
        {
            var cart = _context.Carts.Find(request.Id);
            if (cart == null)
            {
                throw new Exception("Cart not found!");
            }

            cart.UserID = request.UserID;
            _context.SaveChanges();
        }
    }
}
