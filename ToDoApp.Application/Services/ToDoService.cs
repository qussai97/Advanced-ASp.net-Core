using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Dtos;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Services
{
   public class ToDoService
    {
        private readonly IToDoRepositry _repositry ;

        public ToDoService(IToDoRepositry repositry)
        {
            _repositry = repositry  ;
        }

        public List<ToDoItemDto> GetAll()
        {
            var result  = _repositry.GetAll();
            //var mappedResult = result.Select(i => new ToDoItemDto() {
            //Description = i.Description,
            //Title = i.Title,    
            //DueDate = i.DueDate,    
            //ID = i.ID,
            //PriorityLeavel = i.PriorityLeavel,   
            //Tags = i.Tags,
            //UserId = i.UserId,
            
            //});

            var mappedResult = result.Adapt<List<ToDoItemDto>>();
            return mappedResult; 
        }

        public ToDoItemDto Create(CreateToDoItemDto createToDoItemDto)
        {
            var ToDoItem  = createToDoItemDto.Adapt<ToDoItem>();
            _repositry.Create(ToDoItem);
               return ToDoItem.Adapt<ToDoItemDto>();
        }

        public ToDoItemDto GetByID(int id)
        {
            var result = _repositry.GetById(id);
            

            var mappedResult = result.Adapt<ToDoItemDto>();
            return mappedResult;
        }
        public bool Update(int id , UpdateToDoItemDto ubdateDoItemDto)
        {
            var ToDoItem = _repositry.Update(id, ubdateDoItemDto);



            if (ToDoItem )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool Delete(int id)
        {
            var DeleteToDoItem = _repositry.Delete(id);



            if (DeleteToDoItem)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<ToDoItemDto> SearchByname(string SearchByname)
        {
            var result = _repositry.SearchByname(SearchByname);


            var mappedResult = result.Adapt<List<ToDoItemDto>>();
            return mappedResult;
        }
        public bool UpdateCompleate(int id)
        {
            var result = _repositry.UpdateCompleate(id);

            if (result)
            {
                return true;
            }
            return false;


        }
        

    }
}
