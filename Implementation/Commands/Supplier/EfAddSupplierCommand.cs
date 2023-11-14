using Application.DTO;
using Application.UseCases.Commands.Supplier;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Supplier
{
    public class EfAddSupplierCommand : IAddSupplierCommand
    {
        public int Id => 0;

        public string Name => "Add Supplier";

        public string Description => "Add Supplier Using EF Framework.";

        private readonly WebShopContext _context;

        public EfAddSupplierCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(AddSupplierDTO request)
        {
            var supplier = new Domain.Entities.Supplier
            {
                SupplierName = request.SupplierName,
                SupplierContact = request.SupplierContact,
            };

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }
    }
}
