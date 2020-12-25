using BlogDuLich.BAL.Interface;
using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.User;
using BlogDuLich.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL
{
    public class UserService : IUserService

    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<CreateUserResult> CreateUser(CreateUserRequest request)
        {
            return await userRepository.CreateUser(request);
        }
        public async Task<UpdateUserResult> UpdateUser(UpdateUserRequest request)
        {
            return await userRepository.UpdateUser(request);
        }
        public async Task<DeleteUserResult> DeleteUser(DeleteUserRequest request)
        {
            return await userRepository.DeleteUser(request);
        }

        public async Task<IEnumerable<User>> Gets()
        {
            return await userRepository.Gets();
        }


    }
}
