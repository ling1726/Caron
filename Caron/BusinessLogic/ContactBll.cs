using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Caron.DAL.Models;
using Caron.DAL.ViewModels.Contact;

namespace Caron.BusinessLogic
{
    public class ContactBll : BaseBll
    {
        public ContactBll(CaronEntities db) : base(db)
        {
        }

        public void CreateContact(ContactViewModel viewModel)
        {
            var newContact = new Contact
            {
                Message = viewModel.Message,
                Email = viewModel.Email,
                ContactSubjectId = viewModel.ContactSubjectId
            };

            Db.Contacts.Add(newContact);
            Db.SaveChanges();
        }
    }
}