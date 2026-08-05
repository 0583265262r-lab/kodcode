using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagementSystem.Repositories
{
    public class BooksRepository:IBooksRepository
    {
        private LibraryDbContext _context;

        public BooksRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BookModel>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }
        public async Task<BookModel?> GetByIdAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
            return book;
        }
        public async Task<BookModel> CreateBook(BookModel book)
        {
            var create = _context.Books.Add(book);
            var savedCreate = await _context.SaveChangesAsync();
            return await GetByIdAsync(savedCreate);
        }
    }
}
