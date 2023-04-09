using DoctorWhoDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public void Update(int AuthorId,string AuthorName)
        {
            var author = _context.Authors.Find(AuthorId);
            if(author != null)
            author.AuthorName = AuthorName;
            _context.SaveChanges();
        }

        public void Delete(int AuthorId)
        {
            var author = _context.Authors.Find(AuthorId);
            if(author != null)
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }

        public void Add(string AuthorName)
        {
            _context.Authors.Add(new Author { AuthorName = AuthorName });
            _context.SaveChanges();
        }
    }
}
