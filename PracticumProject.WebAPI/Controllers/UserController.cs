using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticumProject.common.DTO;
using PracticumProject.Services.Interfaces;
using PracticumProject.WebAPI.Models;

namespace PracticumProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
         
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> GetById(int id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<UserDTO> Put(int id, [FromBody]UserModel userModel)
        {
          return await _userService.UpdateAsync(new UserDTO(
              userModel.FirstName,
              userModel.LastName,
              userModel.Tz,
              id,
              userModel.DateOfBirth,
              userModel.egender,
              userModel.HMO
              ));
        }
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel userModel)
        {
           return await _userService.AddAsync(new UserDTO(
               userModel.FirstName,
               userModel.LastName,
               userModel.Tz,
               userModel.Id,
               userModel.DateOfBirth,
               userModel.egender,
               userModel.HMO
               ));
        }

    }
}
