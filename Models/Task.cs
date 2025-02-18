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
        public string User { get; set; }

        [Required, MaxLength(25)]
        public string Name { get; set; } = "";

        [Required]
        [MaxLength(150, ErrorMessage="Description is to long.")]
        public string Description { get; set; } = "";

        public DateTime CreateDate { get; set; }
        
        public Status Status { get; set; }

        public Task(string name, string description)
        {
            User = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Name = name;
            Description = description;
            CreateDate = DateTime.Now;
            Status = Status.NotStarted;
        }
    }  
}