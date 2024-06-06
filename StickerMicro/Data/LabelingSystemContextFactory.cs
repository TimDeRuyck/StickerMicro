using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerMicro.Data
{
    public class LabelingSystemContextFactory : IDesignTimeDbContextFactory<LabelingSystemContext>
    {
        public LabelingSystemContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LabelingSystemContext>();
            optionsBuilder.UseSqlite("Data Source=LabelingSystem.db");

            return new LabelingSystemContext(optionsBuilder.Options);
        }
    }
}
