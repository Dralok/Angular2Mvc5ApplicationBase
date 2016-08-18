using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    [TypeLite.TsClass]
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}