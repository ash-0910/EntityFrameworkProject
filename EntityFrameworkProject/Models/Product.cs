using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Models
{
    public class Product
    {
        [Required]
        public int Price { get; set; }

        public string Description { get; set; }
        [Key]
        public string Name { get; set; }
    }
}
