using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class Post
    {
        // Class for representing the Post entity

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
        public List<PostTag> PostTagCollection { get; set; }
    }
}