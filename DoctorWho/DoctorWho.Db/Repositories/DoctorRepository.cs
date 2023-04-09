using DoctorWhoDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public void Update(int DoctorId, int DoctorNumber, string? DoctorName, DateTime? BirthDate, DateTime? FirstEpisodeDate, DateTime? LastEpisodeDate)
        {
            var doctor = _context.Doctors.Find(DoctorId);
            if (doctor != null) {
                doctor.DoctorNumber = DoctorNumber;
                doctor.DoctorName = DoctorName;
                doctor.BirthDate = BirthDate;
                doctor.FirstEpisodeDate = FirstEpisodeDate;
                doctor.LastEpisodeDate = LastEpisodeDate;
            }

            _context.SaveChanges();
        }

        public void Delete(int DoctorId)
        {
            var doctor = _context.Doctors.Find(DoctorId);
            if (doctor != null) 
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }

        public void Add( int DoctorNumber, string? DoctorName, DateTime? BirthDate, DateTime? FirstEpisodeDate, DateTime? LastEpisodeDate)
        {
            var doctor = new Doctor {
            DoctorNumber = DoctorNumber,
            DoctorName = DoctorName,
            BirthDate = BirthDate,
            FirstEpisodeDate = FirstEpisodeDate,
            LastEpisodeDate = LastEpisodeDate
            };

            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
           return _context.Doctors.ToList();
        }
    }
}
