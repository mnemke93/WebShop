using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class OrderDTO
    {
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public int UserID { get; set; }
        public int PaymentID { get; set; }
    }

    public class AddOrderDTO
    {
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public int UserID { get; set; }
        public int PaymentID { get; set; }
    }

    public class UpdateOrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public int UserID { get; set; }
        public int PaymentID { get; set; }
    }

    public class DeleteOrderDTO
    {
        public int Id { get; set; }
    }
}
