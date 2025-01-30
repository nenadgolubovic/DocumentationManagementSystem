using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class Engine
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public int Type { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CSN {  get; set; }

        public int TSN { get; set; }
    }
}
