using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using modusapi.Models;
//using System.Data.Entity;

namespace modusapi.Data
{
    public class ModusDbContext : DbContext
    {
        public ModusDbContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<employees> employees { get; set; }

    }
}
