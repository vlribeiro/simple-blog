using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class Tag
    {
        // Class for representing the Tag entity

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<PostTag> PostTagCollection { get; set; }
    }
}