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
    public class EfDeleteSupplierCommand : IDeleteSupplierCommand
    {
        public int Id => 0;

        public string Name => "Delete Supplier";

        public string Description => "Delete Supplier Using EF Framework.";

        private readonly WebShopContext _context;

        public EfDeleteSupplierCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(DeleteSupplierDTO request)
        {
            var supplier = _context.Suppliers.Find(request.Id);

            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }
    }
}
