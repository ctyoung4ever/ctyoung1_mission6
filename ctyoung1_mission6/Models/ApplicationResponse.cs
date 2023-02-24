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

        public int CategoryId { get; set; }
        public Category Category { get; set; }
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
        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string Notes { get; set; }



    }
}
