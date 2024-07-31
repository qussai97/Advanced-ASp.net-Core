using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Enum;

namespace ToDoApp.Application.Dtos
{
   public class CreateToDoItemDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string UserId { get; set; }
        public List<string> Tags { get; set; }
        public bool IsCompleate { get; set; }
        public PriorityLeavel PriorityLeavel { get; set; }

    }
    public class UpdateToDoItemDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string UserId { get; set; }
        public List<string> Tags { get; set; }
        public bool IsCompleate { get; set; }
        public PriorityLeavel PriorityLeavel { get; set; }

    }
    public class ToDoItemDto
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string UserId { get; set; }
        public List<string> Tags { get; set; }
        public bool IsCompleate { get; set; }
        public PriorityLeavel PriorityLeavel { get; set; }

    }
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string UserId { get; set; }
        public List<string> Tags { get; set; }
        public bool IsCompleate { get; set; }
        public PriorityLeavel PriorityLeavel { get; set; }

    }

}
