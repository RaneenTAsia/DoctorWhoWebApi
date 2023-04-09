using DoctorWhoDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public void Update(int EpisodeId, int SeriesNumber, int EpisodeNumber,string EpisodeType, string Title, int AuthorId, int DoctorId, string? Notes)
        {
            var episode = _context.Episodes.Find(EpisodeId);
            if (episode != null)
            {
                episode.SeriesNumber= SeriesNumber;
                episode.EpisodeNumber= EpisodeNumber;
                episode.EpisodeType= EpisodeType;
                episode.Title= Title;
                episode.AuthorId= AuthorId;
                episode.DoctorId= DoctorId;

            }

            _context.SaveChanges();
        }

        public void Delete(int EpisodeId)
        {
            var Episode = _context.Episodes.Find(EpisodeId);
            if(Episode != null)
            _context.Episodes.Remove(Episode);
            _context.SaveChanges();
        }

        public void Add(int EpisodeId, int SeriesNumber, int EpisodeNumber,string EpisodeType, string Title, int AuthorId, int DoctorId, string? Notes)
        {
            var episode = new Episode
            {
                SeriesNumber = SeriesNumber,
                EpisodeNumber = EpisodeNumber,
                EpisodeType = EpisodeType,
                Title = Title,
                AuthorId = AuthorId,
                DoctorId = DoctorId

            };

            _context.Episodes.Add(episode);
            _context.SaveChanges();
        }
    }
}
