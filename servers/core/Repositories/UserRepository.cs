using Microsoft.EntityFrameworkCore.Diagnostics;
using ReadersCorner.Core.Models;
using ReadersCorner.Core.Repositories.Configurations;
using ReadersCorner.Core.Repositories.Interfaces;

namespace ReadersCorner.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Add(User user)
        {
            var result = _context.Users.Add(user);
            _ = SaveChanges();
            return result.Entity;
        }

        public bool Delete(User model)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public User Update(User model)
        {
            throw new NotImplementedException();
        }

        private bool SaveChanges() => _context.SaveChanges() >= 0;
    }
}