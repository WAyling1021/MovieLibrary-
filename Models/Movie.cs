﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLibrary.Models
{
    public class Movie
    {
        public int Id { get; internal set; }
        public string Title { get; set; }  
        public string Genre { get; set; }
        public string DirectorName { get; set; }
        
    }
}