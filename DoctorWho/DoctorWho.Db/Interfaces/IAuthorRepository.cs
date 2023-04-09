using DoctorWho.Db.Enums;
using DoctorWhoDomain.Entities;

namespace DoctorWho.Db.Interfaces
{
    public interface IAuthorRepository
    {
        Task AddAuthorAsync(string AuthorName);
        Task<bool> AuthorExistsAsync(int authorId);
        Task<Result> DeleteAuthorAsync(int AuthorId);
        Task<Author?> GetAuthorByIdAsync(int authorId);
        Task SaveChangesAsync();
        Task<Result> UpdateAuthorAsync(int AuthorId, string AuthorName);
    }
}