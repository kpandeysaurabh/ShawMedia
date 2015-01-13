using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shaw.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Video> Videos { get; set; }  
    }
}