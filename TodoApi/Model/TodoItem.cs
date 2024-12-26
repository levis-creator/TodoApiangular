using System.ComponentModel.DataAnnotations;

namespace TodoApi.Model
{
    public class TodoItem
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string TaskName { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public bool isCompleted { get; set; } = false;
        public DateOnly DueDate { get; set; }
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime UpdatedAt { get; set;} = DateTime.Now;
    }
}
