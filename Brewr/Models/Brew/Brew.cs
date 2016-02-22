using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brewr.Models.Brew
{
    public class Brew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BrewDate { get; set; }
        public DateTime Secondaried { get; set; }
        public DateTime Bottled { get; set; }
    }
}