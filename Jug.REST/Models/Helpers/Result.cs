using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jug.REST.Models.Helpers
{
    public class Result
    {
        public List<string> Status { get; set; }
        public Result()
        {
            Status = new List<string>();
        }
    }
}