using BlogDuLich.Domain.Request.Post;
using BlogDuLich.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL.Interface
{
  public  interface IPostService
    {
        Task<IEnumerable<Post>> Gets();
        Task<CreatePostResult> CreatePost(CreatePostRequest request);
        Task<UpdatePostResult> UpdatePost(UpdatePostRequest request);
        Task<DeletePostResult> DeletePost(DeletePostRequest request);
    }
}
