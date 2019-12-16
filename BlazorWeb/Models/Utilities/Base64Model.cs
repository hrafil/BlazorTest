using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models.Utilities
{
    public class Base64Model
    {
        [Required]
        public string Input { get; set; }

        public string Output { get; set; }

        public Base64OperationType OperationType { get; }

        public Base64Model(Base64OperationType operationType) { OperationType = operationType; }
    }
}
