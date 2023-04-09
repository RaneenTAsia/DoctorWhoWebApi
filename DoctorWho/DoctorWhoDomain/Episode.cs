using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Episode
    {
        public Episode()
        {
            EpisodeCompanions = new List<EpisodeCompanion>();
            EpisodeEnemies = new List<EpisodeEnemy>();
        }
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public string Notes { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
        public List<EpisodeEnemy> EpisodeEnemies { get; set; }

    }
}
