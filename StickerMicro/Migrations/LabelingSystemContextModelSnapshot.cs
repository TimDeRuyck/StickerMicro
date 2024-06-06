﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StickerMicro;

#nullable disable

namespace StickerMicro.Migrations
{
    [DbContext(typeof(LabelingSystemContext))]
    partial class LabelingSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("StickerMicro.core.Entities.MediaType", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MediaCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ShelfLife")
                        .HasColumnType("INTEGER");

                    b.HasKey("MediaId");

                    b.ToTable("MediaTypes");

                    b.HasData(
                        new
                        {
                            MediaId = 1,
                            MediaCode = "TSB",
                            MediaName = "Tryptic soy broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 2,
                            MediaCode = "CET",
                            MediaName = "Cetrimide agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 3,
                            MediaCode = "PBS",
                            MediaName = "Phosphate buffer solution (pH 7,0)",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 4,
                            MediaCode = "GLB",
                            MediaName = "glutamate broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 5,
                            MediaCode = "CCA",
                            MediaName = "Chromogenic Coliform Agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 6,
                            MediaCode = "VRB",
                            MediaName = "violet red bile glucose agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 7,
                            MediaCode = "McB",
                            MediaName = "MacConkey broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 8,
                            MediaCode = "McA",
                            MediaName = "MacConkey agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 9,
                            MediaCode = "PCA",
                            MediaName = "Plate count agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 10,
                            MediaCode = "TSA",
                            MediaName = "Tryptic soy agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 11,
                            MediaCode = "SDA",
                            MediaName = "Sabouraud-dextrose agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 12,
                            MediaCode = "BGA",
                            MediaName = "Brilliant green agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 13,
                            MediaCode = "XLD",
                            MediaName = "Xylose Lysine Deoxycholate agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 14,
                            MediaCode = "MKB",
                            MediaName = "Müller-Kauffman tetrathionate-novobiocin broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 15,
                            MediaCode = "RVS",
                            MediaName = "Rappaport-Vassiliadis Salmonella",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 16,
                            MediaCode = "BPW",
                            MediaName = "Buffered peptone water",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 17,
                            MediaCode = "MYA",
                            MediaName = "Meat yeast agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 18,
                            MediaCode = "LSB",
                            MediaName = "Lactose Sulfiet broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 19,
                            MediaCode = "NCP",
                            MediaName = "Natrium chloride-peptone buffer",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 20,
                            MediaCode = "ABM",
                            MediaName = "Antibiotic medium",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 21,
                            MediaCode = "EEB",
                            MediaName = "Enterobacteriaceae enrichment broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 22,
                            MediaCode = "SAB",
                            MediaName = "Sabouraud dextrose agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 23,
                            MediaCode = "BTW",
                            MediaName = "Buffer + tween",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 24,
                            MediaCode = "LAB",
                            MediaName = "Lactose broth",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 25,
                            MediaCode = "HER",
                            MediaName = "Herellea agar",
                            ShelfLife = 3
                        },
                        new
                        {
                            MediaId = 26,
                            MediaCode = "MSA",
                            MediaName = "Mannitol salt agar",
                            ShelfLife = 3
                        });
                });

            modelBuilder.Entity("StickerMicro.core.Entities.PrintLabel", b =>
                {
                    b.Property<int>("LabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MediaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("LabelId");

                    b.HasIndex("MediaId");

                    b.ToTable("PrintLabels");
                });

            modelBuilder.Entity("StickerMicro.core.Entities.PrintLabel", b =>
                {
                    b.HasOne("StickerMicro.core.Entities.MediaType", "MediaType")
                        .WithMany("PrintLabels")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");
                });

            modelBuilder.Entity("StickerMicro.core.Entities.MediaType", b =>
                {
                    b.Navigation("PrintLabels");
                });
#pragma warning restore 612, 618
        }
    }
}
