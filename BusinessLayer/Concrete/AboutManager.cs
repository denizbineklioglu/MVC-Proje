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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutDelete(Category about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(Category about)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAboutList()
        {
            throw new NotImplementedException();
        }

        public About GetById(int aboutID)
        {
            throw new NotImplementedException();
        }
    }
}
