using System;
using System.ComponentModel.DataAnnotations;

namespace testapp.Models
{
    public class Personne
    {
        public int Id { get; set; }

        //[Required]
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(150, MinimumLength = 4,
                  ErrorMessage = "Last name should be between 4 and 150 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter forname")]
        [StringLength(150, MinimumLength = 4,
                  ErrorMessage = "Last name should be between 4 and 150 characters")]
        public string Forname { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public DateTime BithDay { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }
    }
}
