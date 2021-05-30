using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public Contact GetById(int contactID)
        {
            return _contactDal.Get(x => x.ContactID == contactID);
        }

        public List<Contact> GetContactList()
        {
            return _contactDal.List();
        }
    }
}
