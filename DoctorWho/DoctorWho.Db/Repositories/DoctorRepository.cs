using DoctorWho.Db.Enums;
using DoctorWho.Db.Interfaces;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public async Task<(Doctor, Result)> UpdateDoctorAsync( Doctor doctor)
        {
            var doctorToUpdate = await _context.Doctors.FindAsync(doctor.DoctorId);

            if (doctorToUpdate != null)
            {
                doctorToUpdate.DoctorNumber = doctor.DoctorNumber;
                doctorToUpdate.DoctorName = doctor.DoctorName;
                doctorToUpdate.BirthDate = doctor.BirthDate;
                doctorToUpdate.FirstEpisodeDate = doctor.FirstEpisodeDate;
                doctorToUpdate.LastEpisodeDate = doctor.LastEpisodeDate;
            }

            var status = await _context.SaveChangesAsync();
            return (doctorToUpdate, Result.Completed);
        }

        public async Task<Result> DeleteDoctorAsync(int doctorId)
        {
            var doctor =await _context.Doctors.FindAsync(doctorId);

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
            

            if (await _context.Doctors.AnyAsync(d => d.DoctorId == doctorId))
            {
                return Result.Failed;
            }

            return Result.Completed;
        }

        public async Task<(Doctor,Result)> AddDoctorAsync(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();

            if(!(await _context.Doctors.AnyAsync(d => d.DoctorId == doctor.DoctorId)))
            {
                return (doctor,Result.Failed);
            }

            return (doctor, Result.Completed);
        }

        public async Task<(IEnumerable<Doctor>,PaginationMetadata)> GetAllDoctorsAsync(int pageNumber, int pageSize)
        {
            var doctorCollection = _context.Doctors.AsNoTracking();

            var totalItemCount = await doctorCollection.CountAsync();

            var paginationMetadata = new PaginationMetadata(totalItemCount, pageSize, pageNumber);

            var doctorCollectionToReturn = await doctorCollection.OrderBy(d => d.DoctorNumber).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToListAsync();

            return (doctorCollectionToReturn, paginationMetadata);
        }

        public async Task<bool> DoctorExistsAsync(int doctorId)
        {
            return await _context.Doctors.AnyAsync(d => d.DoctorId == doctorId);
        }
    }
}
