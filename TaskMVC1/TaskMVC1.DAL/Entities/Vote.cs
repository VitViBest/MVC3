using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMVC1.DAL.Entities
{
    public class Vote
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }
    }
}
