using DoctorWhoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public void AddCompanionEpisode(Companion Companion, int EpisodeId)
        {
            var episode = _context.Episodes.Find(EpisodeId);
            if (episode != null)
            {
                episode.EpisodeCompanions.Add(new EpisodeCompanion { CompanionId = Companion.CompanionId, EpisodeId = EpisodeId });
            }

            _context.SaveChanges();
        }
    }
}
