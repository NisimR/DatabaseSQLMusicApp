using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<AlbumFW> albums { get; set; }//will create albums table. U can configure the name manually. and the fields. 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL("datasource= localhost;port=3306;username=root;password=12345678;database=my_music;");
        public void InitializeDatabase()
        {

            Console.WriteLine("data base... )");
            // Create the database and the related tables - if it does not exist
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure table name is correct
            modelBuilder.Entity<AlbumFW>().ToTable("albumsFW");

            // Add 3 mock records if the table is empty
            
        }

    }

}
