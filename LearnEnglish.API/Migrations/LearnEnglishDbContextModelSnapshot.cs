// <auto-generated />
using System;
using LearnEnglish.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnEnglish.API.Migrations
{
    [DbContext(typeof(LearnEnglishDbContext))]
    partial class LearnEnglishDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LearnEnglish.API.Entities.Text", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TextGroupID")
                        .HasColumnType("int");

                    b.Property<string>("Translate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TranslateNormalized")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ValueNormalized")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("TextGroupID");

                    b.HasIndex("Value")
                        .IsUnique();

                    b.ToTable("Texts");
                });

            modelBuilder.Entity("LearnEnglish.API.Entities.TextGroup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TextGroups");
                });

            modelBuilder.Entity("LearnEnglish.API.Entities.Text", b =>
                {
                    b.HasOne("LearnEnglish.API.Entities.TextGroup", "TextGroup")
                        .WithMany("Texts")
                        .HasForeignKey("TextGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TextGroup");
                });

            modelBuilder.Entity("LearnEnglish.API.Entities.TextGroup", b =>
                {
                    b.Navigation("Texts");
                });
#pragma warning restore 612, 618
        }
    }
}
