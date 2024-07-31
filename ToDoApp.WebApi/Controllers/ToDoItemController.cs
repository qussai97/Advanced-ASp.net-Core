using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using ToDoApp.Application.Dtos;
using ToDoApp.Application.Services;

namespace ToDoApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        private readonly ToDoService _service;
        public ToDoItemController(ToDoService service)
        {
            _service = service; 
        }
        [HttpGet]
        public IActionResult  GetAll()
        {
            return Ok( _service.GetAll());
        }
        [HttpPost]
        public IActionResult Create(CreateToDoItemDto toDo)
        {
            _service.Create(toDo);
            return Ok(toDo);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            var result = _service.GetByID(id);
            if (result is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
           
        }

        [HttpPut("{id:int}")]

        public IActionResult Update( int id , UpdateToDoItemDto toDo)
        {
            var result = _service.Update(id , toDo);
            if (result )
            {
                return Ok(true);
            }
            
                return BadRequest("not successfully updated");
            
               
            
        }
        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (result)
            {
                return Ok(true);
            }

            return BadRequest("not successfully Deleted");



        }

        [HttpGet("{TitleNmae}")]
        public IActionResult SearchByname(string TitleNmae)
        {
            var result = _service.SearchByname(TitleNmae);
            if (result is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }

        }


        [HttpPut("Compleate/{C_ID}")]

        public IActionResult UpdateCompleate(int C_ID)
        {
            var result = _service.UpdateCompleate(C_ID);
            if (result)
            {
                return Ok(true);
            }

            return BadRequest("not successfully updated");



        }
       
    }
}
