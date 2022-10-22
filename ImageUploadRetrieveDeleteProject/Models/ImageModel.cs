﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageUploadRetrieveDeleteProject.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string? ImageTitle { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Upload Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile? ImageFile { get; set; }
    }
}
