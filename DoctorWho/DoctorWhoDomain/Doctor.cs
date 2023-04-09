using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Doctor
    {
        private DateTime birthDate;

        public Doctor()
        {
            Episodes = new List<Episode>();
        }

        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }
        public string? DoctorName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? FirstEpisodeDate { get; set; }
        public DateTime? LastEpisodeDate { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
