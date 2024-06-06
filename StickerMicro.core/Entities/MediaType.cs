using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StickerMicro.core.Entities
{
    public class MediaType
    {
        public int MediaId { get; set; }
        public string MediaCode { get; set; }
        public string MediaName { get; set; }
        public int ShelfLife { get; set; }
        public List<Label> Labels { get; set; }
    }
}
