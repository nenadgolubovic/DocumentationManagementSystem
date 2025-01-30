using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Models;

namespace DMS.ViewModels
{
    public class ComponentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public ComponentViewModel() 
        { 
        }
        public ComponentViewModel(Component model) 
        { 
            Id = model.Id;
            Name = model.Name;
            Description = model.Description;
            Type = model.Type;
           
        }

        public Component ConvertViewModel(ComponentViewModel model)
        {
            return new Component
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Type = model.Type,
            };
        }
    }
}
