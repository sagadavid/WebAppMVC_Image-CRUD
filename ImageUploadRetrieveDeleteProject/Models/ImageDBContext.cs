using Microsoft.EntityFrameworkCore;

namespace ImageUploadRetrieveDeleteProject.Models
{
    public class ImageDBContext:DbContext
    {
        public ImageDBContext(DbContextOptions<ImageDBContext> options):base(options)
        {

        }

        public DbSet <ImageModel> Images { get; set; }

    }
}
