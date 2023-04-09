using DoctorWho.Db.Enums;
using DoctorWho.Db.Repositories;
using DoctorWhoDomain.Entities;

namespace DoctorWho.Db.Interfaces
{
    public interface IDoctorRepository
    {
        Task<(Doctor,Result)> AddDoctorAsync(Doctor doctor);
        Task<Result> DeleteDoctorAsync(int DoctorId);
        Task<(IEnumerable<Doctor>, PaginationMetadata)> GetAllDoctorsAsync(int pagenumber, int pageSize);
        Task<(Doctor, Result)> UpdateDoctorAsync(Doctor doctor);
        Task<bool> DoctorExistsAsync(int DoctorId);
    }
}