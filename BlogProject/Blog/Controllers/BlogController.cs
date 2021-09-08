using Blog.DataAccess.Data;
using Blog.Models;
using Blog.DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IUnitofWork _db;

        public BlogController(IUnitofWork db)
        {
            this._db = db;
        }


        //Get Blogs
        [HttpGet]
        public IList<Blogs> GetAllBlogs()
        {
            IList<Blogs> blogs = _db.Blogs.GetAll().ToList();

            return blogs;
        }


        //Get Blog by Id
        [HttpGet("{id}")]
        public Blogs GetBlogById(int id)
        {
            Blogs blog = _db.Blogs.Get(id);
            if (blog == null)
            {
                throw new Exception("Not Found");
            }

            return blog;
        }

        //Add Blog
        [HttpPost]
        public OkResult  PostNewBlog(Blogs blog)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Not Found");
            }

            _db.Blogs.Add(blog);
            _db.Save();

            return Ok();
        }

        //Update Blog
        [HttpPut]
        public OkResult Put(Blogs blog)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Data.");
            }

            var existingBlog = _db.Blogs.Get(blog.BlogId);

            if (existingBlog != null)
            {
                existingBlog.BlogTitle = blog.BlogTitle;
                existingBlog.BlogContent = blog.BlogContent;

                _db.Save();
            }
            else
            {
                throw new Exception("Not Found");
            }

            return Ok();
        }

        //Delete Blog
        [HttpDelete("{id}")]
        public OkResult DeleteBlog(int id)
        {
            var blog = _db.Blogs.Get(id);

            if (blog == null)
            {
                throw new Exception("Not Found");
            }

            _db.Blogs.Delete(blog);
            _db.Save();

            return Ok();
        }

    }
}
