using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class CategoryDTO
    {
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }

    public class AddCategoryDTO
    {
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }

    public class UpdateCategoryDTO
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }

    public class DeleteCategoryDTO
    {
        public int Id { get; set; }
    }
}
