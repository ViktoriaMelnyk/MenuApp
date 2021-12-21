using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MenuApp.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Kcal { get; set; }
        public string Source_link { get; set; }
        public string Difficulty { get; set; }
        public string Time { get; set; }
        public string Image_url { get; set; }

        

    }
}
