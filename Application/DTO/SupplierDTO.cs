using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class SupplierDTO
    {
        public string? SupplierName { get; set; }
        public string? SupplierContact { get; set; }
    }

    public class AddSupplierDTO
    {
        public string? SupplierName { get; set; }
        public string? SupplierContact { get; set; }
    }

    public class UpdateSupplierDTO
    {
        public int Id { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierContact { get; set; }
    }

    public class DeleteSupplierDTO
    {
        public int Id { get; set; }
    }
}
