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
    public class EfAddCategoryCommand : IAddCategoryCommand
    {
        public int Id => 0;

        public string Name => "Add Category";

        public string Description => "Add Category Using EF Framework.";

        private readonly WebShopContext _context;

        public EfAddCategoryCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(AddCategoryDTO request)
        {
            var category = new Domain.Entities.Category
            {
                CategoryName = request.CategoryName,
                CategoryDescription = request.CategoryDescription,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}
