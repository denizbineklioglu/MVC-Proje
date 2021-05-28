using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAboutList();
        void AboutAdd(About about);
        About GetById(int aboutID);
        void AboutDelete(Category about);
        void AboutUpdate(Category about);
    }
}
