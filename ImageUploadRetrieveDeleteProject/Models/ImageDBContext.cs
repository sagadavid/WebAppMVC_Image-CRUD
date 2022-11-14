using Microsoft.EntityFrameworkCore;

namespace ImageUploadRetrieveDeleteProject.Models
{
    public class ImageDBContext:DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ImageDBContext(DbContextOptions<ImageDBContext> options):base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public DbSet <ImageModel> Images { get; set; }
        public DbSet<Proposal> Proposals { get; set; }  

    }
}
