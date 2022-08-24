using Microsoft.EntityFrameworkCore;

namespace TestCatalogApp.Models
{
    public class FolderContext:DbContext
    {
        public DbSet<Folder> Folder { get; set; }

        public FolderContext(DbContextOptions<FolderContext> options)
            : base(options)
        {
           
        }
    }
}
