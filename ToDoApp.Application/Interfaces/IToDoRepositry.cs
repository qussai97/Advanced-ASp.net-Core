using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Dtos;

namespace ToDoApp.Application.Interfaces
{
   public interface IToDoRepositry
    {
     public    List<ToDoItem> GetAll();
     public ToDoItem GetById(int Id);
     public  List<ToDoItem> SearchByname(string name);
     public bool UpdateCompleate(int id);
     
     public  ToDoItem Create(ToDoItem dto);
     public  bool Update( int id ,UpdateToDoItemDto dto);
        public bool Delete(int id); 
            
    }
}
