using Application.DTO;
using Application.UseCases.Commands.Order;
using Application.UseCases.Commands.OrderDetail;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.OrderDetail
{
    public class EfAddOrderDetailCommand : IAddOrderDetailCommand
    {
        public int Id => 0;

        public string Name => "Add Order Detail";

        public string Description => "Add Order Detail Using EF Framework.";

        private readonly WebShopContext _context;

        public EfAddOrderDetailCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(AddOrderDetailDTO request)
        {
            var orderDetail = new Domain.Entities.OrderDetail
            {
                Quantity = request.Quantity,
                Price = request.Price,
                OrderID = request.OrderID,
                ProductID = request.ProductID,
            };

            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }
    }
}
