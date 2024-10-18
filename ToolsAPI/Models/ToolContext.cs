using Microsoft.EntityFrameworkCore;

namespace ToolsAPI.Models
{
    public class ToolContext : DbContext
    {
        public ToolContext(DbContextOptions<ToolContext> options)
        : base(options)
        {
        }
        public DbSet<ToolItem> ToolItems { get; set; } = null!;
    }
}
