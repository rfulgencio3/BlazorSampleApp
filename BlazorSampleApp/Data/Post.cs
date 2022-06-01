using System.ComponentModel.DataAnnotations;

namespace BlazorSampleApp.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
