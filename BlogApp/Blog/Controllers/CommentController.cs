using Blog.DataAccess.Repository;
using Blog.Models;
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
    public class CommentController : ControllerBase
    {
        private readonly IUnitofWork _db;

        public CommentController(IUnitofWork db)
        {
            this._db = db;
        }


        //Get Comments
        [HttpGet]
        public ObjectResult GetAllComments()
        {
            IList<Comments> comments = _db.Comments.GetAll().ToList();

            return Ok(comments);
        }

        //Get Comment by Id
        [HttpGet("{id}")]
        public ObjectResult GetCommentById(int id)
        {
            Comments comment = _db.Comments.Get(id);
            if (comment == null)
            {
                throw new Exception("Not Found");
            }

            return Ok(comment);
        }

        //Add Comment
        [HttpPost]
        public OkResult PostNewComment(Comments comment)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid data.");
            }

            _db.Comments.Add(comment);
            _db.Save();

            return Ok();
        }


        //Delete Method
        [HttpDelete("{id}")]
        public OkResult DeleteComment(int id)
        {
            var comment = _db.Comments.Get(id);

            if (comment == null)
            {
                throw new Exception("Not Found");
            }

            _db.Comments.Delete(comment);
            _db.Save();

            return Ok();
        }
    }
}
