using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayerr.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class IstatistikManager : IIstatistikService
    {
        Context context = new Context();

        public int CountCategory()
        {
            int categoryCount = context.Categories.Count();
            return categoryCount;
        }

        public int CountHeading()
        {
            int headingCount = context.Headings.Count(x => x.Category.CategoryName == "Yazılım");
            return headingCount;
        }

        public int CountStatus()
        {
            int trueCount = context.Categories.Count(x => x.CategoryStatus == true);
            int falseCount = context.Categories.Count(x => x.CategoryStatus == false);
            int countStatus = trueCount - falseCount;
            return countStatus;
        }

        public int CountWriter()
        {
            int writerCount = context.Writers.Count(x => x.WriterName.Contains("a"));
            return writerCount;
        }

        public string MaxCategory()
        {
            string categoryName = context.Headings.Max(x => x.Category.CategoryName);
            return categoryName;
        }
    }
}
