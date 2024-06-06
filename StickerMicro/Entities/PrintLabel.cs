using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerMicro.core.Entities
{
    public class PrintLabel
    {
        public int LabelId { get; set; }
        public int MediaId { get; set; }
        public int SerialNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExpiryDate { get; set; }
        public MediaType MediaType { get; set; }
    }
}
