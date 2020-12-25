using BlogDuLich.BAL.Interface;
using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.Contact;
using BlogDuLich.Domain.Response.Contact;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL
{
    public class ContactService :  IContactService

    {
        private readonly IContactRepository contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task<CreateContactResult> CreateContact(CreateContactRequest request)
        {
            return await contactRepository.CreateContact(request);
        }
        public async Task<UpdateContactResult> UpdateContact(UpdateContactRequest request)
        {
            return await contactRepository.UpdateContact(request);
        }
        public async Task<DeleteContactResult> DeleteContact(DeleteContactRequest request)
        {
            return await contactRepository.DeleteContact(request);
        }

        public async Task<IEnumerable<Contact>> Gets()
        {
            return await contactRepository.Gets();
        }


    }
}
