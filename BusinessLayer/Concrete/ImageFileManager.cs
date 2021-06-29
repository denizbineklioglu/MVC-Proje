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
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefiledal;

        public ImageFileManager(IImageFileDal imagefiledal)
        {
            _imagefiledal = imagefiledal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefiledal.List();

        }
    }
}
