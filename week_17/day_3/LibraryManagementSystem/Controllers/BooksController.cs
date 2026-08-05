using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController: ControllerBase
    {
        private IBooksRepository _repository;
        public BooksController(IBooksRepository repository)
        {
            _repository = repository;
        }
        //GET /api/books - Get all books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetAll()
        {
            return Ok(await _repository.GetAllAsync());
        }
        //GET /api/books/{id} - Get book by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<BookModel>>GetById(int id)
        {
            var book = await _repository.GetByIdAsync(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }
        [HttpPost]
        public async Task<ActionResult<BookModel>> CreateBook(BookModel book)
        {
            return Ok(await _repository.CreateBook(book));
        }


    }
}
