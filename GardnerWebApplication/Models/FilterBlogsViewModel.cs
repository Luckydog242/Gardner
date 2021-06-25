using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GardnerWebApplication.Models
{
    public class FilterBlogsViewModel
    {
        public List<Blog> Blogs { get; set; }
        public string SearchTitle { get; set; }
        public string SearchAlias { get; set; }
    }
}
