﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDuLich.Domain.Response.Category
{
  public  class UpdateCategoryResult
    {
        public int CategoryId { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
