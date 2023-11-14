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
    public class EfAddCartCommand : IAddCartCommand
    {
        public int Id => 0;

        public string Name => "Add Cart";

        public string Description => "Add Cart Using EF Framework.";

        private readonly WebShopContext _context;

        public EfAddCartCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(AddCartDTO request)
        {
            var cart = new Domain.Entities.Cart
            {
                UserID = request.UserID,
            };

            _context.Carts.Add(cart);
            _context.SaveChanges();
        }
    }
}
