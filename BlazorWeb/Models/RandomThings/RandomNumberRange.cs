using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models.RandomThings
{
    public class RandomNumberRange : IValidatableObject
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid positive integer Number")]
        public int From { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid positive integer Number")]
        public int To { get; set; } = 100;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (From > To)
            {
                yield return new ValidationResult("From cannot be greater than To.",
                    new[] { nameof(From) });
            }
        }
    }
}
