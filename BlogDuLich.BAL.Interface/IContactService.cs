using BlogDuLich.Domain.Request.Contact;
using BlogDuLich.Domain.Response.Contact;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL.Interface
{
  public  interface IContactService
    {
        Task<IEnumerable<Contact>> Gets();
        Task<CreateContactResult> CreateContact(CreateContactRequest request);
        Task<UpdateContactResult> UpdateContact(UpdateContactRequest request);
        Task<DeleteContactResult> DeleteContact(DeleteContactRequest request);
    }
}
