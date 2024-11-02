using Microsoft.AspNetCore.Mvc;
using WrapFusionContact.Data;
using WrapFusionContact.Models;
using WrapFusionContact.ViewModels;

namespace WrapFusionContact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactMeController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ContactMeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("")]
        public IActionResult SendContactInfo(ContactMeVm vm)
        {
            Contact contact = new Contact
            {
                FullName = vm.FullName,
                PhoneNumber = vm.PhoneNumber,
                Email = vm.Email,
                Content = vm.Content
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok(new { Message = "Thông tin liên hệ đã được gửi thành công." });
        }
    }
}