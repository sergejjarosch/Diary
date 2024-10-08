using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        [StringLength(100, MinimumLength = 3, 
            ErrorMessage = "Title must be between 3 and 100 Characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a content")]
        public string Content { get; set; } = string.Empty ;

        [Required(ErrorMessage = "Please enter a date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now ;
    }
}
