using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticumProject.common.DTO;
using PracticumProject.Services.Interfaces;
using PracticumProject.WebAPI.Models;

namespace PracticumProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildUserController : ControllerBase
    {
        private readonly IChildUserService _childUserService;

        public ChildUserController(IChildUserService childUserService)
        {
            _childUserService = childUserService;
        }
        [HttpGet]
        public async Task<List<ChildUserDTO>> Get()
        {
            return await _childUserService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildUserDTO> GetById(int id)
        {
            return await _childUserService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childUserService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<ChildUserDTO> Put(int id, [FromBody] ChildUserModel childUserModel)
        {
            return await _childUserService.UpdateAsync(new ChildUserDTO(
                childUserModel.Name,
                childUserModel.Tz,
                childUserModel.DateOfBirth,
                id,
                childUserModel.ParentId
                ));
        }
        [HttpPost]
        public async Task<ChildUserDTO> Post([FromBody] ChildUserModel childUserModel)
        {
           return await _childUserService.AddAsync(new ChildUserDTO(
               childUserModel.Name,
               childUserModel.Tz,
               childUserModel.DateOfBirth,
               childUserModel.Id,
               childUserModel.ParentId
               ));
        }
    }
}
