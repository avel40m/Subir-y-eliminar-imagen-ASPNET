using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Image.Models
{
    public class ImageModel
    {
        [Key]
        [DisplayName("ID")]
        public int ImageId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [DisplayName("Titulo")]
        public string Title { get; set; } 
        [Column(TypeName ="nvarchar(100)")]
        [DisplayName("Imagen")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload Name")]
        public IFormFile ImageFile { get; set; }      
    }
}