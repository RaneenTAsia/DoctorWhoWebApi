using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Entities
{
    public class ViewEpisodes
    {
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string? Title { get; set; }
        public string? AuthorName { get; set; }
        public string? DoctorName { get; set; }
        public string? Companions { get; set; }
        public string? Enemies { get; set; }

        public override string ToString()
        {
            return "Series:" + SeriesNumber + ", Episode:" + EpisodeNumber + ", Title:" + Title + ", Author:" + AuthorName +
                ", DoctorName:" + DoctorName + ", Companions:" + Companions + "Enemies:" + Enemies;
        }
    }
}
