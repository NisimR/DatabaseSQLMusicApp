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
        public DbSet<Album2> albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL("datasource= localhost;port=3306;username=root;password=root;database=music2;");

        
    }

}
