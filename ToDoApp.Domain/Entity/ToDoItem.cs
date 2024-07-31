using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Enum;

namespace ToDoApp.Domain.Entity
{
    class ToDoItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool ISComplete { get; set; }
        public DateTime?  DueDate { get; set; }
        public string UserId { get; set; }
        public List<string> Tags { get; set; }
        public PriorityLeavel PriorityLeavel { get; set; }


    }
}
