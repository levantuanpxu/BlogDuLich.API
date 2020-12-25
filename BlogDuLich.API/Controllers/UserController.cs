using BlogDuLich.BAL.Interface;
using BlogDuLich.Domain.Request.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDuLich.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("/api/user/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await userService.Gets());
        }

        [HttpPost]
        [Route("/api/user/create")]
        public async Task<OkObjectResult> Create(CreateUserRequest request)
        {
            return Ok(await userService.CreateUser(request));
        }

        [HttpPost]
        [Route("/api/user/update")]
        public async Task<OkObjectResult> Update(UpdateUserRequest request)
        {
            return Ok(await userService.UpdateUser(request));
        }

        [HttpDelete]
        [Route("/api/user/delete")]
        public async Task<OkObjectResult> Delete(DeleteUserRequest request)
        {
            return Ok(await userService.DeleteUser(request));
        }
    }
}