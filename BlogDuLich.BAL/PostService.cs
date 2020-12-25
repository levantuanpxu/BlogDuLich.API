using BlogDuLich.BAL.Interface;
using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.Post;
using BlogDuLich.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL
{
    public class PostService : IPostService

    {
        private readonly IPostRepository postRepository;

        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public async Task<CreatePostResult> CreatePost(CreatePostRequest request)
        {
            return await postRepository.CreatePost(request);
        }
        public async Task<UpdatePostResult> UpdatePost(UpdatePostRequest request)
        {
            return await postRepository.UpdatePost(request);
        }
        public async Task<DeletePostResult> DeletePost(DeletePostRequest request)
        {
            return await postRepository.DeletePost(request);
        }

        public async Task<IEnumerable<Post>> Gets()
        {
            return await postRepository.Gets();
        }


    }
}
