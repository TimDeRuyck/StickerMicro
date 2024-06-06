using Microsoft.EntityFrameworkCore;
using StickerMicro.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerMicro
{
    public class LabelingSystemContext : DbContext
    {
        public LabelingSystemContext(DbContextOptions<LabelingSystemContext> options) : base(options)
        {
        }

        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<PrintLabel> PrintLabels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlite("Data Source=LabelingSystem.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MediaType>().HasKey(mt => mt.MediaId);
            modelBuilder.Entity<PrintLabel>().HasKey(pl => pl.LabelId);
            modelBuilder.Entity<PrintLabel>().HasOne(pl => pl.MediaType).WithMany(mt => mt.PrintLabels).HasForeignKey(pl => pl.MediaId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MediaType>().HasData(
                new MediaType { MediaId = 1, MediaCode = "TSB", MediaName = "Tryptic soy broth", ShelfLife = 3 },
                new MediaType { MediaId = 2, MediaCode = "CET", MediaName = "Cetrimide agar", ShelfLife = 3 },
                new MediaType { MediaId = 3, MediaCode = "PBS", MediaName = "Phosphate buffer solution (pH 7,0)", ShelfLife = 3 },
                new MediaType { MediaId = 4, MediaCode = "GLB", MediaName = "glutamate broth", ShelfLife = 3 },
                new MediaType { MediaId = 5, MediaCode = "CCA", MediaName = "Chromogenic Coliform Agar", ShelfLife = 3 },
                new MediaType { MediaId = 6, MediaCode = "VRB", MediaName = "violet red bile glucose agar", ShelfLife = 3 },
                new MediaType { MediaId = 7, MediaCode = "McB", MediaName = "MacConkey broth", ShelfLife = 3 },
                new MediaType { MediaId = 8, MediaCode = "McA", MediaName = "MacConkey agar", ShelfLife = 3 },
                new MediaType { MediaId = 9, MediaCode = "PCA", MediaName = "Plate count agar", ShelfLife = 3 },
                new MediaType { MediaId = 10, MediaCode = "TSA", MediaName = "Tryptic soy agar", ShelfLife = 3 },
                new MediaType { MediaId = 11, MediaCode = "SDA", MediaName = "Sabouraud-dextrose agar", ShelfLife = 3 },
                new MediaType { MediaId = 12, MediaCode = "BGA", MediaName = "Brilliant green agar", ShelfLife = 3 },
                new MediaType { MediaId = 13, MediaCode = "XLD", MediaName = "Xylose Lysine Deoxycholate agar", ShelfLife = 3 },
                new MediaType { MediaId = 14, MediaCode = "MKB", MediaName = "Müller-Kauffman tetrathionate-novobiocin broth", ShelfLife = 3 },
                new MediaType { MediaId = 15, MediaCode = "RVS", MediaName = "Rappaport-Vassiliadis Salmonella", ShelfLife = 3 },
                new MediaType { MediaId = 16, MediaCode = "BPW", MediaName = "Buffered peptone water", ShelfLife = 3 },
                new MediaType { MediaId = 17, MediaCode = "MYA", MediaName = "Meat yeast agar", ShelfLife = 3 },
                new MediaType { MediaId = 18, MediaCode = "LSB", MediaName = "Lactose Sulfiet broth", ShelfLife = 3 },
                new MediaType { MediaId = 19, MediaCode = "NCP", MediaName = "Natrium chloride-peptone buffer", ShelfLife = 3 },
                new MediaType { MediaId = 20, MediaCode = "ABM", MediaName = "Antibiotic medium", ShelfLife = 3 },
                new MediaType { MediaId = 21, MediaCode = "EEB", MediaName = "Enterobacteriaceae enrichment broth", ShelfLife = 3 },
                new MediaType { MediaId = 22, MediaCode = "SAB", MediaName = "Sabouraud dextrose agar", ShelfLife = 3 },
                new MediaType { MediaId = 23, MediaCode = "BTW", MediaName = "Buffer + tween", ShelfLife = 3 },
                new MediaType { MediaId = 24, MediaCode = "LAB", MediaName = "Lactose broth", ShelfLife = 3 },
                new MediaType { MediaId = 25, MediaCode = "HER", MediaName = "Herellea agar", ShelfLife = 3 },
                new MediaType { MediaId = 26, MediaCode = "MSA", MediaName = "Mannitol salt agar", ShelfLife = 3 }
            );
        }
    }
}
