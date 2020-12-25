using BlogDuLich.Domain.Request.User;
using BlogDuLich.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL.Interface
{
   public interface IUserService
    {
        Task<IEnumerable<User>> Gets();
        Task<CreateUserResult> CreateUser(CreateUserRequest request);
        Task<UpdateUserResult> UpdateUser(UpdateUserRequest request);
        Task<DeleteUserResult> DeleteUser(DeleteUserRequest request);
    }
}
