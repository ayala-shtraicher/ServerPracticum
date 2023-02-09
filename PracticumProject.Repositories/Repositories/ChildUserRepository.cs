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
    public class ChildUserRepository : IChildUserRepository
    {
        private readonly IContext _contex;

        public ChildUserRepository(IContext contex)
        {
            _contex = contex;
        }


        public async Task<ChildUser> AddAsync(ChildUser childUser)
        {
            var c = new ChildUser(childUser);
            _contex.Children.Add(c);
            await _contex.SaveChangesAsync();
            return new ChildUser(c.Name,c.Tz,c.DateOfBirth,c.Id,c.ParentId);
        }

        public async Task DeleteAsync(int id)
        {
            _contex.Children.Remove(GetByIdAsync(id).Result);
            await _contex.SaveChangesAsync();
        }

        public async Task<List<ChildUser>> GetAllAsync()
        {
            return await _contex.Children.ToListAsync();
        }

        public async Task<ChildUser> GetByIdAsync(int id)
        {
            return await _contex.Children.FindAsync(id);
        }

        public async Task<ChildUser> UpdateAsync(ChildUser childUser)
        {
            var c = _contex.Children.Update(childUser);
            await _contex.SaveChangesAsync();
            return c.Entity;
        }
    }
}
