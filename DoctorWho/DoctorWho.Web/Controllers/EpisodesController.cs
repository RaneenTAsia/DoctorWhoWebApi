using AutoMapper;
using DoctorWho.Db.Interfaces;
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
    }
}
