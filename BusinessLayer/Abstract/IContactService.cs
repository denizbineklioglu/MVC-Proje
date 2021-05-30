using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
      
            List<Contact> GetContactList();
            void ContactAdd(Contact contact);
            Contact GetById(int contactID);
            void ContactDelete(Contact contact);
            void ContactUpdate(Contact contact);

       
    }
}
