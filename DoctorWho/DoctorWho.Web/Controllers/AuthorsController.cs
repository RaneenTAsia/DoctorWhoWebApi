using AutoMapper;
using Azure;
using DoctorWho.Db.Interfaces;
using DoctorWhoDomain.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController :ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPatch("{authorId}")]
        public async Task<ActionResult> PartiallyUpdateAuthor(int authorId, JsonPatchDocument<AuthorForUpdateDto> patchDocument)
        {
            var authorFromRepo = await _authorRepository.GetAuthorByIdAsync(authorId);

            if(authorFromRepo == null)
            {
                return NotFound();
            }

            var authorToPatch = _mapper.Map<AuthorForUpdateDto>(authorFromRepo);

            patchDocument.ApplyTo(authorToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(authorToPatch))
            {
                return BadRequest(ModelState);
            }

            var patchedAuthor = _mapper.Map(authorToPatch, authorFromRepo);

            await _authorRepository.SaveChangesAsync();

            return Ok(_mapper.Map<AuthorDto>(patchedAuthor));
        }

        [HttpPut("{authorId}")]
        public async Task<ActionResult> UpdateAuthor(int authorId, AuthorForUpdateDto author)
        {
            var authorFromRepo = await _authorRepository.GetAuthorByIdAsync(authorId);

            if(author == null)
            {
                return NotFound();
            }

            var updatedAuthor = _mapper.Map(author, authorFromRepo);

            await _authorRepository.SaveChangesAsync();

            return Ok(_mapper.Map<AuthorDto>(updatedAuthor));
        }   
    }
}
