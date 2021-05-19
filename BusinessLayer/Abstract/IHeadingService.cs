using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetHeadingList();
        void HeadingAdd(Heading heading);
        Heading GetById(int id);
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);
    }
}
