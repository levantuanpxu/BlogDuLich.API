using BlogDuLich.BAL.Interface;
using BlogDuLich.Domain.Request.Post;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDuLich.API.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }
        [HttpGet]
        [Route("/api/post/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await postService.Gets());
        }

        [HttpPost]
        [Route("/api/post/create")]
        public async Task<OkObjectResult> Create(CreatePostRequest request)
        {
            return Ok(await postService.CreatePost(request));
        }

        [HttpPost]
        [Route("/api/post/update")]
        public async Task<OkObjectResult> Update(UpdatePostRequest request)
        {
            return Ok(await postService.UpdatePost(request));
        }

        [HttpDelete]
        [Route("/api/post/delete")]
        public async Task<OkObjectResult> Delete(DeletePostRequest request)
        {
            return Ok(await postService.DeletePost(request));
        }
    }
}