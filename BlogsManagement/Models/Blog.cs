﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlogsManagement.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
                
        public string Title { get; set; }

        public string Des { get; set; }

        public string Detail { get; set; }

        public int Category { get; set; }

        public bool IsPublished { get; set; }

        public DateTime DatePublic { get; set; }

        public string Position { get; set; }

        public string Thumb { get; set; }

        public List<Blog> ShowAllBlogs { get; set; }
    }
}