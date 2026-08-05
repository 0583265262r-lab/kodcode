using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories
{
    public interface IBooksRepository
    {
        Task<IEnumerable<BookModel>> GetAllAsync();
        Task<BookModel?> GetByIdAsync(int id);
        Task<BookModel> CreateBook(BookModel book);
    }
}
