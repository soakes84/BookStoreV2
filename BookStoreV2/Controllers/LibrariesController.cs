using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreV2.Entities;
using BookStoreV2.Repository.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrariesController : ControllerBase
    {
        private readonly ILibraryRepository<Author> _libraryRepository;

        public LibrariesController(ILibraryRepository<Author> libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        [HttpGet]
        [Route("GetAuthor")]
        public IActionResult GetAuthor(Guid authorId)
        {
            try
            {
                Author author = _libraryRepository.GetAuthor(authorId);
                return Ok(author);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetAllAuthor")]
        public IActionResult GetAllAuthor()
        {
            IEnumerable<Author> authors = _libraryRepository.GetAllAuthor();
            return Ok(authors);
        }

        [HttpPost]
        [Route("AddAuthor")]
        public IActionResult AddAuthor([FromBody]Author authorparam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Author author = _libraryRepository.PostAuthor(authorparam);
                    return Ok(author);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}