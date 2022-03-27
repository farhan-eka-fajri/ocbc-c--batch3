using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Data{

    public class ApiDbContext : DbContext{

        public virtual DbSet<ItemData> Items {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){
            
        }
    }
}