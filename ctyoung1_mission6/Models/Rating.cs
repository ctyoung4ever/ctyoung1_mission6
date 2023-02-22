using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ctyoung1_mission6.Models
{
    public class Rating
    {
        [Key]
        [Required]
        public int RatingID { get; set; }
        public string rating { get; set; }
    }
}
