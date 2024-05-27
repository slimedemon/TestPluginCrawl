using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCrawl.Models
{
    public class Novel
    {
        public int Id { get; set; }
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public bool Status { get; set; }
        public float Rating { get; set; }
        public Author[] Authors { get; set; }
        public Category[] Categories { get; set; }
        public Chapter[] Chapters { get; set; }
        public Plugins.Source[] Sources { get; set; }
    }
}
