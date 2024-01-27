using BlogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogAPI.Controllers
{
    [RoutePrefix("api/blogs")]
    public class BlogInfoController : ApiController
    {
        private readonly BlogRepository _blogRepository = new BlogRepository();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllBlogs()
        {
            var blogs = _blogRepository.GetAllBlogs();
            return Ok(blogs);
        }

        [HttpGet]
        [Route("{blogId}")]
        public IHttpActionResult GetBlogById(int blogId)
        {
            var blog = _blogRepository.GetBlogById(blogId);
            return Ok(blog);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult SaveBlog(BlogInfo blog)
        {
            _blogRepository.SaveBlog(blog);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult UpdateBlog(BlogInfo blog)
        {
            _blogRepository.UpdateBlog(blog);
            return Ok();
        }

        [HttpDelete]
        [Route("{blogId}")]
        public IHttpActionResult DeleteBlog(int blogId)
        {
            _blogRepository.DeleteBlog(blogId);
            return Ok();
        }
    }
}
