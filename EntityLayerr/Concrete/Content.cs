using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
   public class Content
    {
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int WriteID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
