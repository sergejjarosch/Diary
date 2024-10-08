using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the content")]
        public string Content { get; set; } = string.Empty ;

        [Required(ErrorMessage = "Please enter the date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now ;
    }
}
