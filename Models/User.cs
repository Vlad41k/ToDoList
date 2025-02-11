using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace TODO_app.Models
{
    public class User  
    {
        public int Id  { get; set; }
        public string Name { get; set; } = "";
        public ICollection<Task> Tasks { get; set;}
    }  
}   