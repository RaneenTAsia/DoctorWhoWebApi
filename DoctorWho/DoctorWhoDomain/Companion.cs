using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Companion
    {
        public Companion()
        {
            EpisodeCompanions = new List<EpisodeCompanion>();
        }

        public int CompanionId { get; set; }
        public string? CompanionName { get; set; }
        public string? WhoPlayed { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
    }
}
