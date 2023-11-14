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
    public class EfUpdateUserCommand : IUpdateUserCommand
    {
        public int Id => 0;

        public string Name => "Update User";

        public string Description => "Update User Using EF Framework";

        private readonly WebShopContext _context;

        public EfUpdateUserCommand(WebShopContext context)
        {
            _context = context;
        }

        public void Execute(UpdateUserDTO request)
        {
            var user = _context.Users.Find(request.Id);

            if (user == null)
            {
                throw new Exception("User not found!");
            }

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.PhoneNumber = request.PhoneNumber;
            user.UserAdress = request.UserAdress;
            user.IsAdmin = request.IsAdmin;

            _context.SaveChanges();
        }
    }
}
