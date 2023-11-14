using Application.DTO;
using Application.UseCases.Commands.User;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.User
{
    public class EfAddUserCommand : IAddUserCommand
    {
        public int Id => 0;

        public string Name => "Add User";

        public string Description => "Add User Using EF Framework";

        private readonly WebShopContext _context;

        public EfAddUserCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(AddUserDTO request)
        {
            var user = new Domain.Entities.User
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password = request.Password,
                PhoneNumber = request.PhoneNumber,
                UserAdress = request.UserAdress,
                IsAdmin = request.IsAdmin
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
