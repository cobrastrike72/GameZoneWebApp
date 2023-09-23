using System.ComponentModel.DataAnnotations;

namespace Madrid.GameZone.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult($"Maximum Allowed Size Is {_maxFileSize} bytes");
                }
            }
            return ValidationResult.Success;
        }
    }
}
