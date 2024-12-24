﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class ResponseResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public dynamic? Data { get; set; }
    }
}
