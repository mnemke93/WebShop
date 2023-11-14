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
    public class EfUpdateCategoryCommand : IUpdateCategoryCommand
    {
        public int Id => 0;

        public string Name => "Update Category";

        public string Description => "Update Category Using EF Framework.";

        private readonly WebShopContext _context;

        public EfUpdateCategoryCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(UpdateCategoryDTO request)
        {
            var category = _context.Categories.Find(request.Id);
            if (category == null)
            {
                throw new Exception("Category not found!");
            }
            category.CategoryName = request.CategoryName;
            category.CategoryDescription = request.CategoryDescription;

            _context.SaveChanges();
        }
    }
}
