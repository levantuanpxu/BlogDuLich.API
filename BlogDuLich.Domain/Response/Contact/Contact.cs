using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDuLich.Domain.Response.Contact
{
   public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
      
    }
}
