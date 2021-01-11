using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMaster3.Models;


namespace ProiectMaster3.Data
{
    public class ContextFacultate : DbContext
    {
        public ContextFacultate(DbContextOptions<ContextFacultate> options) : base(options)
        { }
        public DbSet<Participare> Participari { get; set; }
        public DbSet<Curs> Cursuri { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Carte> Carti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participare>().ToTable("Participare");
            modelBuilder.Entity<Curs>().ToTable("Curs");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Profesor>().ToTable("Profesor");
            modelBuilder.Entity<Carte>().ToTable("Carte");
        }
    }
}
