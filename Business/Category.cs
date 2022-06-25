using System;
using System.ComponentModel.DataAnnotations;

namespace Business
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
