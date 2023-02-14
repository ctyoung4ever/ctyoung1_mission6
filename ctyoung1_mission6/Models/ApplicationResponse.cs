using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ctyoung1_mission6.Models
{
    public class ApplicationResponse
    {


        [Required]
        [Key]
        public int movieId { get; set; }
        [Required]

        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }

        [Required]

        public string Rating { get; set; }
        
        public bool Edited { get; set; }
        
        public string Lent { get; set; }
        
        public string Notes { get; set; }
  


    }
}
