using DoctorWho.Db.Enums;
using DoctorWho.Db.Repositories;
using DoctorWhoDomain.Entities;

namespace DoctorWho.Db.Interfaces
{
    public interface IEpisodeRepository
    {
        Task<(Episode, Result)> AddEpisodeAsync(Episode episode);
        Task DeleteEpisodeAsync(int EpisodeId);
        Task UpdateEpisodeAsync(Episode episode);
        Task<(IEnumerable<Episode>, PaginationMetadata)> GetEpisodesAsync(int pageNumber, int pageSize);
        Task<(int, Enemy, Result)> AddEnemyToEpisodeAsync(int episodeId, Enemy enemy);
        Task<(int, Companion, Result)> AddCompanionToEpisodeAsync(int episodeId, Companion companion);
        Task<bool> EpisodeExistsAsync(int episodeId);
    }
}