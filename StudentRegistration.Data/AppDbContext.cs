using Microsoft.EntityFrameworkCore;
using StudentRegistration.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //   {
        //      base.OnConfiguring(optionsBuilder);
        //     optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=studentdt;Trusted_Connection=True;");
        // }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentFeature> StudentFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //entitylerin özellikleri
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //mapin kısa yolu // bütün assembly'yi tara // mapin klasötünü tarıyor seed'ide mapin klasörüne at o da taransın

            base.OnModelCreating(modelBuilder);
        }
    }
}
