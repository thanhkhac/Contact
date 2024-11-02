using System.ComponentModel.DataAnnotations;

namespace WrapFusionContact.ViewModels
{
    public class ContactMeVm
    {
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string? PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Email sai định dạng")]
        public string? Email { get; set; }
        public string? Content { get; set; }
    }
}