using AutoMapper;
using DoctorWho.Db.Enums;
using DoctorWho.Db.Interfaces;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DoctorWho.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        private readonly IEpisodeRepository _episodeRepository;
        private readonly IMapper _mapper;
        const int maxPageSize = 10;

        public EpisodesController(IEpisodeRepository episodeRepository, IMapper mapper)
        {
            _episodeRepository = episodeRepository ?? throw new ArgumentNullException(nameof(episodeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult> GetEpisodes(int pageNumber =1, int pageSize = 2)
        {
            if (pageSize > maxPageSize)
            {
                pageSize = maxPageSize;
            }

            var (episodes, paginationMetadata) = await _episodeRepository.GetEpisodesAsync(pageNumber, pageSize);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<EpisodeDto>>(episodes));
        }

        [HttpPost]
        public async Task<ActionResult> CreateEpisode(EpisodeForCreationDto episode)
        {
            var episodeToBeCreated= _mapper.Map<Episode>(episode);

            var (doctorCreated, result) = await _episodeRepository.AddEpisodeAsync(episodeToBeCreated);

            if(result == Result.Completed)
            return Ok($"EpisodeId: {doctorCreated.EpisodeId}");

            return StatusCode(409);

        }

        [HttpPost("{episodeId}")]
        public async Task<ActionResult> AddEnemyToEpisode(int episodeId, [FromBody]EnemyForCreationDto enemy)
        {
            var episodeExists = await _episodeRepository.EpisodeExistsAsync(episodeId);
            if (!episodeExists)
            {
                return NotFound();
            }

            var targetEnemy = _mapper.Map<Enemy>(enemy);

            var (foundEpisodeId, enemyCreated, result) = await _episodeRepository.AddEnemyToEpisodeAsync(episodeId, targetEnemy);

            var enemyToReturn = _mapper.Map<EnemyDto>(enemyCreated);
            if(result == Result.Completed)
                return Ok($"EpisodeId: {foundEpisodeId},\nEnemy:\n {enemyToReturn.ToString()}");

            return StatusCode(409);
        }
    }
}
