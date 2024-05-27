﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCrawl.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public Novel[] Novels { get; set; }
    }
}
