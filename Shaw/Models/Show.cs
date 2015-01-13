using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shaw.Models
{
    public class Show
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; } 
    }
}