using DoctorWhoDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public void Update(int CompanionId, string CompanionName)
        {
            var companion = _context.Companions.Find(CompanionId);
            if (companion != null)
                companion.CompanionName = CompanionName;
            _context.SaveChanges();
        }

        public void Delete(int CompanionId)
        {
            var author = _context.Companions.Find(CompanionId);
            if (author != null)
            _context.Companions.Remove(author);
            _context.SaveChanges();
        }

        public void Add(string CompanionName, string WhoPlayed)
        {
            _context.Companions.Add(new Companion { CompanionName = CompanionName, WhoPlayed = WhoPlayed});
            _context.SaveChanges();
        }

        public Companion GetCompanionById(int CompanionId)
        {
            var companion = _context.Companions.Find(CompanionId);

            if(companion != null)
                return _context.Companions.Find(CompanionId);

                throw new Exception("Companion Does Not Exist");
            
        }
    }
}
