using Microsoft.AspNetCore.Mvc;
using NetCore.Repositories;

namespace NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _bookReponsitory;

        public BookController(IBookRepository bookRepository)
        {
            _bookReponsitory = bookRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = _bookReponsitory.GetAll();
            return Ok(books);
        }

        [HttpGet("{Id}")]
        public IActionResult GetId(int Id)
        {
            var book = _bookReponsitory.Get(Id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

    }
}