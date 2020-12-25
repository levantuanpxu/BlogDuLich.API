using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDuLich.Domain.Response.Post
{
  public  class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string FullContent { get; set; }
        public string Image { get; set; }

        public Date Published { get; set; }
        public int CategoryId { get; set; }
        public int ContactId { get; set; }
    }
}
