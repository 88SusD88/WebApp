using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }

    }
}
