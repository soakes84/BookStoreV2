﻿using System;
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
        [Route("GetAllAuthor")]
        public IActionResult GetAllAuthor()
        {
            IEnumerable<Author> authors = _libraryRepository.GetAllAuthor();
            return Ok(authors);
        }
    }
}