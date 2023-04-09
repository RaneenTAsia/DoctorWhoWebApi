using DoctorWhoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public void AddEnemyEpisode(Enemy Enemy, int EpisodeId)
        {
            var episode = _context.Episodes.Find(EpisodeId);
            if (episode != null) 
            {
                episode.EpisodeEnemies.Add(new EpisodeEnemy { EnemyId = Enemy.EnemyId, EpisodeId = EpisodeId});
            }

            _context.SaveChanges();
        }
    }
}
