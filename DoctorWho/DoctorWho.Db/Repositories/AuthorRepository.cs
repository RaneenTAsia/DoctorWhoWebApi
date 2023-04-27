using DoctorWho.Db.Enums;
using DoctorWho.Db.Interfaces;
using DoctorWhoDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public async Task<Result> UpdateAuthorAsync(int AuthorId, string AuthorName)
        {
            var author = await _context.Authors.FindAsync(AuthorId);
            if (author != null)
            {
                author.AuthorName = AuthorName;
                await _context.SaveChangesAsync();
                return Result.Completed;
            }
            return Result.Failed;
        }

        public async Task<Result> DeleteAuthorAsync(int AuthorId)
        {
            var author = await _context.Authors.FindAsync(AuthorId);
            if (author != null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
                return Result.Completed;
            }
            return Result.Failed;
        }

        public async Task AddAuthorAsync(string AuthorName)
        {
            _context.Authors.Add(new Author { AuthorName = AuthorName });
            await _context.SaveChangesAsync();

        }

        public async Task<Author?> GetAuthorByIdAsync(int authorId)
        {
            return await _context.Authors.FindAsync(authorId);
        }

        public async Task<bool> AuthorExistsAsync(int authorId)
        {
            return await _context.Authors.AnyAsync(a => a.AuthorId == authorId);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        Task<Author?> IAuthorRepository.GetAuthorByIdAsync(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
