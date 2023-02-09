using Microsoft.EntityFrameworkCore;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticumProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _contex;

        public UserRepository(IContext contex)
        {
            _contex = contex;
        }

        public async Task<User> AddAsync(User user)
        {
            var u = new User(user);
            _contex.Users.Add(u);
            await _contex.SaveChangesAsync();
            return new User(u.FirstName,u.LastName,u.Tz,u.Id,u.DateOfBirth,u.egender,u.HMO);
        }

        public async Task DeleteAsync(int id)
        {
            _contex.Users.Remove(GetByIdAsync(id).Result);
            await _contex.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _contex.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _contex.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var u = _contex.Users.Update(user);
            await _contex.SaveChangesAsync();
            return u.Entity;
        }
    }
}
