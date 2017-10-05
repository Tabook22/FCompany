using Microsoft.EntityFrameworkCore;

namespace FCApi.Models
{
    public class FCDbContext:DbContext
    {
        public FCDbContext(DbContextOptions<FCDbContext>options)

        :base(options){
        }


        public DbSet<Post> Posts {get;set;}

        public DbSet<Image> Images {get;set;}


    }
}