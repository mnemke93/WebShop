using Application.DTO;
using Application.UseCases.Commands.Category;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Category
{
    public class EfDeleteCategoryCommand : IDeleteCategoryCommand
    {
        public int Id => 0;

        public string Name => "Delete Category";

        public string Description => "Delete Category Using EF Framework.";

        private readonly WebShopContext _context;

        public EfDeleteCategoryCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(DeleteCategoryDTO request)
        {
            var category = _context.Categories.Find(request.Id);

            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
