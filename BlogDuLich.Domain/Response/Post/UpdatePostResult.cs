using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDuLich.Domain.Response.Post
{
  public  class UpdatePostResult
    {
        public int PostId { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
