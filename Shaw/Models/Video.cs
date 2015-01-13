using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shaw.Models
{
    public class Video
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Timelines { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string ThumbnailPath { get; set; }
    }
}