using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDuLich.Domain.Response.User
{
   public class UpdateUserResult
    {
        public int UserId { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
