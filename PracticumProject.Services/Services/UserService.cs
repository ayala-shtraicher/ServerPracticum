using AutoMapper;
using PracticumProject.common.DTO;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private HashSet<string> ParentCollection;
        private UserDTO user;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            ParentCollection = new HashSet<string>();
        }


        public async Task<UserDTO> AddAsync(UserDTO userDTO)
        {
            try
            {
                if(!ParentCollection.TryGetValue(userDTO.Tz,out _))
                {
                    ParentCollection.Add(userDTO.Tz);
                    user= _mapper.Map<UserDTO>(await _userRepository.AddAsync(_mapper.Map<User>(userDTO)));
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            return user;
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO userDTO)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(userDTO)));
        }
    }
}
