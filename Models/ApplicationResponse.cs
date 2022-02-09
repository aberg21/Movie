using System;
using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent {get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public Category categories { get; set; }
    }
}
