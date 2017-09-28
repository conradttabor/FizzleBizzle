using System.ComponentModel.DataAnnotations;

namespace FizzleBizzle.Models
{
    public class IndexViewModel
    {
        [Required]
        [Range(int.MinValue, int.MaxValue, ErrorMessage = "Must be an integer.")]
        public int Start { get; set; }

        [Required]
        [Range(int.MinValue, int.MaxValue, ErrorMessage = "Must be an integer.")]
        public int End { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Fizz { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Buzz { get; set; }

        public bool IsBazzActive { get; set; }
        public int? Bazz { get; set; }
        public Predicate Predicate { get; set; }
        
        public string[] FizzBuzzArray { get; set; }

    }
}