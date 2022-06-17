using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Blogname { get; set; }
        public string BlogDesc { get; set; }
        public string BlogAuthor { get; set; }
        public DateTime BlogCreate { get; set; }
        public string BlogImgUrl { get; set; }

        [NotMapped]
        public IFormFile BlogPhoto { get; set; }
    }
}
