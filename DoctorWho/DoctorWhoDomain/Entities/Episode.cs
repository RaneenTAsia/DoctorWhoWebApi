using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Entities
{
    public class Episode
    {
        public Episode()
        {
            Companions = new List<Companion>();
            Enemies = new List<Enemy>();
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
        public List<Companion> Companions { get; set; }
        public List<Enemy> Enemies { get; set; }

    }
}
