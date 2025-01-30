using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        
        public string Type { get; set; }
    }
}
