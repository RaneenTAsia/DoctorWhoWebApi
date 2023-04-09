using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Entities
{
    public class EpisodeEnemy
    {
        public Enemy Enemy { get; set; }
        public int EnemyId { get; set; }
        public Episode Episode { get; set; }
        public int EpisodeId { get; set; }
    }
}
