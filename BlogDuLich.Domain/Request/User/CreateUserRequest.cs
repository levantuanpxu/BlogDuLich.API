using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDuLich.Domain.Request.User
{
  public  class CreateUserRequest
    {
        //public int UserId { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
    }
}
