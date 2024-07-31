using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Application.Dtos;
using ToDoApp.Application.Interfaces;
using ToDoApp.Infrastructure.Data;

namespace ToDoApp.Infrastructure.Repositries
{
    public class ToDoItemRepositry : IToDoRepositry
    {
        private readonly AppDbContext _context;
        public ToDoItemRepositry(AppDbContext  appDbContext)
        {
            _context = appDbContext;
                
        }
        public ToDoItem Create(ToDoItem dto)
        {
             _context.Add(dto);
            _context.SaveChanges();
            return dto;

        }

       

        public List<ToDoItem> GetAll()
        {
            return _context.ToDoItems.ToList();
        }

        public ToDoItem GetById(int Id)
        {
            return _context.ToDoItems.FirstOrDefault(x => x.ID == Id);
        }

        public bool Update(int id ,UpdateToDoItemDto item)
        {
            var toDoItem = _context.ToDoItems.Find(id);
            if (toDoItem != null)
            {
                toDoItem.Description = item.Description;
                toDoItem.Title = item.Title;
                toDoItem.Tags  = item.Tags;
                toDoItem.DueDate = item.DueDate;
                toDoItem.PriorityLeavel = item.PriorityLeavel;
                _context.SaveChanges();

                return true;

            }
            else
            {
                
                return false;
            }
           
            
          

            
        }

        public bool Delete(int id)
        {
            var toDoItem = _context.ToDoItems.Find(id);
            if (toDoItem != null)
            {
                _context.Remove(toDoItem);
                _context.SaveChanges();

                return true;

            }
            else
            {

                return false;
            }





        }

        public List<ToDoItem>  SearchByname(string name)
        {
            return _context.ToDoItems.Where(x => EF.Functions.Like(x.Title , $"%{name}%") ).ToList();
        }

        public bool UpdateCompleate(int id)
        {
            var toDoItem = _context.ToDoItems.Find(id);

            if (toDoItem != null)
            {
                toDoItem.IsCompleate = true;
                _context.SaveChanges();
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
