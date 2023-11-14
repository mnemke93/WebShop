﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class OrderDetailDTO
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int OrderID { get; set; }
        public int ProductID { get; set; }
    }

    public class AddOrderDetailDTO
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int OrderID { get; set; }
        public int ProductID { get; set; }
    }

    public class UpdateOrderDetailDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int OrderID { get; set; }
        public int ProductID { get; set; }
    }

    public class DeleteOrderDetailDTO
    {
        public int Id { get; set; }
    }
}
