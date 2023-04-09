using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Entities
{
    public class EpisodeCompanion
    {
        public Episode Episode { get; set; }
        public int EpisodeId { get; set; }
        public Companion Companion { get; set; }
        public int CompanionId { get; set; }
    }
}
