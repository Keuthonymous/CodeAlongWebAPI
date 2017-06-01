﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPICodeAlong.Models
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int PublishedYear { get; set; }
    }
}