using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace TODO_app.Models
{
    public enum Status
    {
        NotStarted,
        InProgress,
        Completed
    }
    public class Task  
    {
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime CreateDate { get; set; }
        public Status Status { get; set; }

        public Task(string name, string description)
        {
            User = new User(); 
            Name = name;
            Description = description;
            CreateDate = DateTime.Now;
            Status = Status.NotStarted;
        }
    }  
}