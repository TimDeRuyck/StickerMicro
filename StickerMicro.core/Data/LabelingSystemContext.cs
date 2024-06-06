using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerMicro.core.Data
{
    public class LabelingSystemContext : DbContext
    {
        public LabelingSystemContext(DbContextOptions<LabelingSystemContext> options) : base(options)
        {
        }

        public DbSet<Entities.MediaType> MediaTypes { get; set; }
        public DbSet<Entities.PrintLabel> PrintLabels { get; set; }
    }
}
