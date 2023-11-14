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
    public class EfUpdateSupplierCommand : IUpdateSupplierCommand
    {
        public int Id => 0;

        public string Name => "Update Supplier";

        public string Description => "Update Supplier Using EF Framework.";

        private readonly WebShopContext _context;

        public EfUpdateSupplierCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(UpdateSupplierDTO request)
        {
            var supplier = _context.Suppliers.Find(request.Id);

            if (supplier == null)
            {
                throw new Exception("Supplier not found!");
            }

            supplier.SupplierName = request.SupplierName;
            supplier.SupplierContact = request.SupplierContact;

            _context.SaveChanges();
        }
    }
}
