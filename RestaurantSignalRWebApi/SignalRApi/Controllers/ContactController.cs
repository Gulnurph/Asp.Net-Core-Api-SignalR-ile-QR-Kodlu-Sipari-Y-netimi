using BusinessLayer.Abstract;
using DtoLayer.ContactDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactServices _contactServices;

        public ContactController(IContactServices contactServices)
        {
            _contactServices = contactServices;
        }
        [HttpGet]
        public IActionResult ContactList() {
            _contactServices.GetAll();
            return Ok();


        }
        [HttpPost]
        public IActionResult ContactAdd(CreateContactDto createContact)
        {
            Contact contact = new Contact()
            {
                FooterDescription = createContact.FooterDescription,
                Email = createContact.Email,
                Location = createContact.Location,
                PhoneNumber = createContact.PhoneNumber,

            };
            _contactServices.Add(contact);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
           var value= _contactServices.GetById(id);
            _contactServices.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult ContactUpdate(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact()
            {
                FooterDescription = updateContactDto.FooterDescription,
                Email = updateContactDto.Email,

                Location = updateContactDto.Location,
                PhoneNumber = updateContactDto.PhoneNumber,

            };
            _contactServices.Update(contact);
            return Ok();
        }
    }
}
