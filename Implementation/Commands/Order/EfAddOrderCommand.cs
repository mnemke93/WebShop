using Application.DTO;
using Application.UseCases.Commands.Order;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Order
{
    public class EfAddOrderCommand : IAddOrderCommand
    {
        public int Id => 0;

        public string Name => "Add Order";

        public string Description => "Add Order Using EF Framework";

        private readonly WebShopContext _context;

        public EfAddOrderCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(AddOrderDTO request)
        {
            var order = new Domain.Entities.Order
            {
                OrderDate = request.OrderDate,
                OrderStatus = request.OrderStatus,
                UserID = request.UserID,
                PaymentID = request.PaymentID
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
