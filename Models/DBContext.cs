using Microsoft.EntityFrameworkCore;

namespace WebAppApi.Models
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } = null!;
    }
}
