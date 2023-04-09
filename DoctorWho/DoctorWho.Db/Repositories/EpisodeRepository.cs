using DoctorWho.Db.Enums;
using DoctorWho.Db.Interfaces;
using DoctorWhoDomain;
using DoctorWhoDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository : IEpisodeRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public async Task UpdateEpisodeAsync(Episode episode)
        {
            var episodeToUpdate = await _context.Episodes.FindAsync(episode.EpisodeId);
            if (episodeToUpdate != null)
            {
                episodeToUpdate.SeriesNumber = episode.SeriesNumber;
                episodeToUpdate.EpisodeNumber = episode.EpisodeNumber;
                episodeToUpdate.EpisodeType = episode.EpisodeType;
                episodeToUpdate.Title = episode.Title;
                episodeToUpdate.AuthorId = episode.AuthorId;
                episodeToUpdate.DoctorId = episode.DoctorId;
                episodeToUpdate.Notes = episode.Notes;

            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteEpisodeAsync(int EpisodeId)
        {
            var Episode = await _context.Episodes.FindAsync(EpisodeId);
            if (Episode != null)
                _context.Episodes.Remove(Episode);
            await _context.SaveChangesAsync();
        }

        public async Task<(Episode, Result)> AddEpisodeAsync(Episode episode)
        {
            _context.Episodes.Add(episode);
            await _context.SaveChangesAsync();

            if (!(await _context.Episodes.AnyAsync(e => e.EpisodeId == episode.EpisodeId)))
            {
                return (episode, Result.Failed);
            }

            return (episode, Result.Completed);
        }

        public async Task<(IEnumerable<Episode>, PaginationMetadata)> GetEpisodesAsync(int pageNumber, int pageSize)
        {
            var episodeCollection = _context.Episodes.AsNoTracking();

            var totalItemCount = await episodeCollection.CountAsync();

            var paginationMetadata = new PaginationMetadata(totalItemCount, pageSize, pageNumber);

            var episodeCollectionToReturn = await episodeCollection.OrderBy(e => e.SeriesNumber).ThenBy(e => e.EpisodeNumber).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToListAsync();
            
            return (episodeCollectionToReturn, paginationMetadata);
        }

        public async Task<(int,Enemy,Result)> AddEnemyToEpisodeAsync(int episodeId, Enemy enemy)
        {
            var targetEpisode = await _context.Episodes.FindAsync(episodeId);

            if (targetEpisode != null)
            {
                targetEpisode.Enemies.Add(enemy);
                await _context.SaveChangesAsync();
            }

            if (targetEpisode.Enemies.Any(e => e.EnemyId == enemy.EnemyId)) {
                return (targetEpisode.EpisodeId,enemy, Result.Completed);
            }

            return (targetEpisode.EpisodeId, enemy, Result.Failed);

        }

        public async Task<(int, Companion, Result)> AddCompanionToEpisodeAsync(int episodeId, Companion companion)
        {
            var targetEpisode = await _context.Episodes.FindAsync(episodeId);

            if (targetEpisode != null)
            {
                targetEpisode.Companions.Add(companion);
                await _context.SaveChangesAsync();
            }

            if (targetEpisode.Companions.Any(c => c.CompanionId == companion.CompanionId))
            {
                return (targetEpisode.EpisodeId, companion, Result.Completed);
            }

            return (targetEpisode.EpisodeId, companion, Result.Failed);

        }

        public async Task<bool> EpisodeExistsAsync(int episodeId)
        {
            return await _context.Episodes.AnyAsync(e => e.EpisodeId == episodeId);
        }
    }
}
