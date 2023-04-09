using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Enemy
    {
        public Enemy()
        {
            EpisodeEnemies = new List<EpisodeEnemy>();
        }
        public int EnemyId { get; set; }
        public string? EnemyName { get; set; }
        public string? Description { get; set; }
        public List<EpisodeEnemy> EpisodeEnemies { get; set; }
    }
}
