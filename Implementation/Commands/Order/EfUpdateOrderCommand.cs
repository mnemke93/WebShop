using Application.DTO;
using Application.UseCases.Commands.Order;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Order
{
    public class EfUpdateOrderCommand : IUpdateOrderCommand
    {
        public int Id => 0;

        public string Name => "Update Order";

        public string Description => "Update Order Using EF Framework";

        private readonly WebShopContext _context;

        public EfUpdateOrderCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(UpdateOrderDTO request)
        {
            var order = _context.Orders.Find(request.Id);

            if (order == null)
            {
                throw new Exception("Order not found!");
            }

            order.OrderDate = request.OrderDate;
            order.OrderStatus = request.OrderStatus;
            order.UserID = request.UserID;
            order.PaymentID = request.PaymentID;

            _context.SaveChanges();
        }
    }
}
