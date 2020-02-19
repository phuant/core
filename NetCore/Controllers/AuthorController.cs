using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetCore.Model;
using NetCore.Repositories;
using NetCore.ViewModel;
using System.Collections.Generic;

namespace NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(
            IAuthorRepository authorRepository,
            IMapper mapper
            )
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAll();
            var mapper = _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
            return Ok(mapper);
        }

        [HttpGet("{Id}")]
        public IActionResult GetAuthor(int Id)
        {
            var author = _authorRepository.Get(Id);
            if (author == null)
            {
                return NotFound();
            }
            var mapper = _mapper.Map<AuthorViewModel>(author);
            return Ok(mapper);
        }

        [HttpPost]
        public IActionResult CreateAuthor(AuthorViewModel authorVm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var convertObjectAuthor = _mapper.Map<Author>(authorVm);

            _authorRepository.Add(convertObjectAuthor);
            _authorRepository.Save();

            var createAuthor = _mapper.Map<AuthorViewModel>(convertObjectAuthor);

            return Ok(createAuthor);
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateAuthor(int Id,[FromBody]AuthorViewModel authorVm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var objectAuthor = _authorRepository.Get(Id);
            if (objectAuthor == null)
            {
                return NotFound();
            }

            _mapper.Map(authorVm, objectAuthor);

            _authorRepository.Save();

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var author = _authorRepository.Get(Id);
            if(author == null)
            {
                return NotFound();
            }

            _authorRepository.Delete(author);
            _authorRepository.Save();

            var mapper = _mapper.Map<AuthorViewModel>(author);

            return Ok(mapper);
        }


    }
}