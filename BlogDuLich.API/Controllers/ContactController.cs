using BlogDuLich.BAL.Interface;
using BlogDuLich.Domain.Request.Contact;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDuLich.API.Controllers
{
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpGet]
        [Route("/api/contact/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await contactService.Gets());
        }

        [HttpPost]
        [Route("/api/contact/create")]
        public async Task<OkObjectResult> Create(CreateContactRequest request)
        {
            return Ok(await contactService.CreateContact(request));
        }

        [HttpPost]
        [Route("/api/contact/update")]
        public async Task<OkObjectResult> Update(UpdateContactRequest request)
        {
            return Ok(await contactService.UpdateContact(request));
        }

        [HttpDelete]
        [Route("/api/contact/delete")]
        public async Task<OkObjectResult> Delete(DeleteContactRequest request)
        {
            return Ok(await contactService.DeleteContact(request));
        }
    }
}
