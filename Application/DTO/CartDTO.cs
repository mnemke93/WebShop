using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class CartDTO
    {
        public int UserID { get; set; }
    }

    public class AddCartDTO
    {
        public int UserID { get; set; }
    }

    public class UpdateCartDTO
    {
        public int Id { get; set; }
        public int UserID { get; set; }
    }

    public class DeleteCartDTO
    {
        public int Id { get; set; }
    }
}
