using Microsoft.EntityFrameworkCore;
using DotNET_CRUD.Models;

namespace DotNET_CRUD.Data
{
    public class SuperHeroContext : DbContext
    {
        public SuperHeroContext(DbContextOptions<SuperHeroContext> options): base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}