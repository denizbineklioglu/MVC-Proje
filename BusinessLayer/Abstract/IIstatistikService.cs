using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIstatistikService
    {
        int CountCategory();
        int CountHeading();
        int CountWriter();
        string MaxCategory();
        int CountStatus();
    }
}
