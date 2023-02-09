using PracticumProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Interfaces
{
    public interface IChildUserRepository
    {
        Task<List<ChildUser>> GetAllAsync();
        Task<ChildUser> GetByIdAsync(int id);

        Task<ChildUser> AddAsync(ChildUser childUser);
        Task<ChildUser> UpdateAsync(ChildUser childUser);

        Task DeleteAsync(int id);
    }
}
