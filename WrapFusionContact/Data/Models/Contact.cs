using System.ComponentModel.DataAnnotations;

namespace WrapFusionContact.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Phone]
        public string? PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Email sai định dạng")]
        [MaxLength(255)]
        public string? Email { get; set; }
        public string? Content { get; set; }
    }
}