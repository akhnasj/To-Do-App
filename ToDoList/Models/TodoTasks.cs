using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TodoTasks
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime dueDate { get; set; } 

        public bool IsCompleted { get; set; }
    }
}
