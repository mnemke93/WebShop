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
    public class EfDeleteUserCommand : IDeleteUserCommand
    {
        public int Id => 0;

        public string Name => "Delete User";

        public string Description => "Delete User Using EF Framework";

        private readonly WebShopContext _context;

        public EfDeleteUserCommand(WebShopContext context)
        {
            _context = context;
        }
        public void Execute(DeleteUserDTO request)
        {
            var user = _context.Users.Find(request.Id);
            if (user == null)
            {
                throw new Exception("User not found!");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
