using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleModels.Models
{
    public class ExampleModel
    {
        [Key]
        public int ModelId { get; set; }
        public string Title {get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? SomeDate { get; set; }
   
    }
}
