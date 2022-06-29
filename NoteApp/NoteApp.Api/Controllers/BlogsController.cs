﻿using Microsoft.AspNetCore.Mvc;
using NoteApp.Api.Models;
using NoteApp.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteApp.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly BlogsService _service;

        public BlogsController(BlogsService service)
        {
            _service = service;
        }

        // GET: api/Blogs/GetBlogs
        [HttpGet]
        [Tags("笔记管理")]
        public async Task<ApiResponse> GetBlogsAsync()
        {
            return await _service.GetsResponseAsync();
        }
        // Get api/Blogs/GetBlog
        [HttpGet]
        [Tags("笔记管理")]
        public async Task<ApiResponse> GetBlogAsync(int id)
        {
            return await _service.GetResponseAsync(id);
        }

        // Post api/Blogs/PostBlog
        [HttpPost]
        [Tags("笔记管理")]
        public async Task<ApiResponse> PostBlogAsync(BlogEntity newBlog)
        {
            return await _service.PostResponseAsync(newBlog);
        }

        // Put api/Blogs/PutBlog
        [HttpPut]
        [Tags("笔记管理")]
        public async Task<ApiResponse> PutBlogAsync(BlogEntity newBlog)
        {
            return await _service.PutResponseAsync(newBlog);
        }

        // Delete api/Blogs/DeleteBlog
        [HttpDelete]
        [Tags("笔记管理")]
        public async Task<ApiResponse> DeleteBlogAsync(int id)
        {
            return await _service.DeleteResponseAsync(id);
        }
    }
}
