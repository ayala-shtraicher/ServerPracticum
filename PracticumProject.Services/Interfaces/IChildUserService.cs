using PracticumProject.common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services.Interfaces
{
    public interface IChildUserService
    {
        Task<List<ChildUserDTO>>GetAllAsync();
        Task<ChildUserDTO> GetByIdAsync(int id);

        Task<ChildUserDTO> AddAsync(ChildUserDTO childUserDTO);
        Task<ChildUserDTO> UpdateAsync(ChildUserDTO childUser);
        Task DeleteAsync(int id);
    }
}
