using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ToDoListEF.EF;
using ToDoListEF.Models;
using ToDoListServices.ToDoBlockServices;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private ToDoBlockService service;
        public ToDoListController(ToDoListDbContext context)
        {
            service = new ToDoBlockService(context);
        }
        [HttpGet("")]
        public IActionResult ListToDo()
        {
            return Ok(service.ListBLocks()?.ToList());
        }
        [HttpPut("")]
        public IActionResult AddToDo([FromBody] ToDoBlock block)
        {
            return Ok(service.CreateBlock(block));
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveToDo([FromRoute] int id)
        {
            int responce = service.DeleteBlock(id);
            if(responce == 0)
                return NotFound(id);
            return Ok();
        }
    }
}
