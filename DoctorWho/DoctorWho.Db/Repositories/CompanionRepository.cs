using DoctorWhoDomain.Entities;
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
        public async Task Update(int CompanionId, string CompanionName)
        {
            var companion = _context.Companions.Find(CompanionId);
            if (companion != null)
                companion.CompanionName = CompanionName;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int CompanionId)
        {
            var author = _context.Companions.Find(CompanionId);
            if (author != null)
            {
                _context.Companions.Remove(author);
                await _context.SaveChangesAsync();
            }
            throw new KeyNotFoundException();
        }

        public async Task Add(string CompanionName, string WhoPlayed)
        {
            _context.Companions.Add(new Companion { CompanionName = CompanionName, WhoPlayed = WhoPlayed});
            await _context.SaveChangesAsync();
        }

        public async Task<Companion?> GetCompanionByIdAsync(int companionId)
        {
            var companion = await _context.Companions.FindAsync(companionId);

            if (companion != null)
                return companion;

                throw new Exception("Companion Does Not Exist");
            
        }
    }
}
