using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkuWebRazor_Temp.Models
{

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Order must be between 1-100")]
        public int Display { get; set; }
    }


}

