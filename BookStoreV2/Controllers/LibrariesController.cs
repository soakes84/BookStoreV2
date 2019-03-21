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

        private readonly ILibraryRepository<Book> _libraryRepositoryB;

        public LibrariesController(ILibraryRepository<Author> libraryRepository, ILibraryRepository<Book> libraryRepositoryB)
        {
            _libraryRepository = libraryRepository;
            _libraryRepositoryB = libraryRepositoryB;
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

        [HttpGet]
        [Route("GetAuthorsByGenre")]
        public IActionResult GetAuthorsByGenre(string genre)
        {
            IEnumerable<Author> authors = _libraryRepository.GetAuthorsByGenre(genre);
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

        [HttpPut]
        [Route("UpdateAuthor")]
        public IActionResult UpdateAuthor([FromBody]Author authorparam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Author author = _libraryRepository.UpdateAuthor(authorparam);
                    return Ok(author);
                }
                else
                {

                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("DeleteAuthor")]
        public IActionResult DeleteAuthor(Guid authorId)
        {
            try
            {
                int result = _libraryRepository.DeleteAuthor(authorId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            IEnumerable<Book> books = _libraryRepositoryB.GetAllBooks();
            return Ok(books);
        }
    }
}