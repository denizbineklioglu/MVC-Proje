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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentDelete(Content content)
        {
            _contentDal.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);
        }

        public void ContentAdd(Content content)
        {
            _contentDal.Insert(content);
        }

        public Content GetById(int id)
        {
           return _contentDal.Get(x=> x.ContentID == id);
        }

        public List<Content> GetContentList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }
    }
}
