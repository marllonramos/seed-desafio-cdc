using System.ComponentModel.DataAnnotations;

namespace DesafioCdc.ApplicationService.Requests
{
    public class CreateAuthorRequest
    {
        [Required(ErrorMessage = "Required name.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Required email.")]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Required description.")]
        [MaxLength(400, ErrorMessage = "Maximum value is 400.")]
        public required string Description { get; set; }
    }
}
