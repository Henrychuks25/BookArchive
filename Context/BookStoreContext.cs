using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BookArchive.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookArchive.Context
{
    public partial class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Borrows> Borrows { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Types> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Cyborg;Database=BookStore;User Id=sa;Password=sa@19911023;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.ToTable("authors");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("authorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("books");

                entity.Property(e => e.BookId)
                    .HasColumnName("bookId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Pagecount).HasColumnName("pagecount");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.TypeId).HasColumnName("typeId");
            });

            modelBuilder.Entity<Borrows>(entity =>
            {
                entity.HasKey(e => e.BorrowId);

                entity.ToTable("borrows");

                entity.Property(e => e.BorrowId)
                    .HasColumnName("borrowId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.BroughtDate)
                    .HasColumnName("broughtDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StudentId).HasColumnName("studentId");

                entity.Property(e => e.TakenDate)
                    .HasColumnName("takenDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__students__4D11D63CB6B45387");

                entity.ToTable("students");

                entity.Property(e => e.StudentId)
                    .HasColumnName("studentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__types__F04DF13ABC9F5DDA");

                entity.ToTable("types");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
