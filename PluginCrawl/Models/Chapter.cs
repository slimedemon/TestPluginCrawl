using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCrawl.Models
{
    public class Chapter
    {
        public int Number { get; set; }
        public int NovelId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public Plugins.Source[] Sources { get; set; }
    }
}
