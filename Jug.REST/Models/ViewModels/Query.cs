using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jug.REST.Models.ViewModels
{
    public class Query
    {
        public Jug JugA { get; set; }
        public Jug JugB { get; set; }
        public int finalQuantity { get; set; }
    }
}