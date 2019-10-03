using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskMVC1.DAL.Entities;

namespace TaskMVC1.Models.Home
{
    public class HomeIndexVM
    {
        public List<Article> Articles { get; set; }

        public List<Vote> Votes { get; set; }

        public bool IsVoted { get; set; }

        public PageInfo PageInfo { get; set; }

        public bool ToOlder { get; set; }
    }
}