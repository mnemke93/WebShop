using Application.DTO;
using Application.UseCases.Commands.Order;
using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Order
{
    public class EfDeleteOrderCommand : IDeleteOrderCommand
    {
        public int Id => 0;

        public string Name => "Delete Order";

        public string Description => "Delete Order Using EF Framework.";

        private readonly WebShopContext _context;

        public EfDeleteOrderCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(DeleteOrderDTO request)
        {
            var order = _context.Orders.Find(request.Id);

            if (order == null)
            {
                throw new Exception("Order not found!");
            }

            _context.Orders.Remove(order);

            _context.SaveChanges();
        }
    }
}
