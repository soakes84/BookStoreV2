﻿using BookStoreV2.Entities;
using BookStoreV2.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreV2.Repository.Implementation
{
    public class LibraryRepository : ILibraryRepository<Author>, ILibraryRepository<Book>
    {
        readonly LibraryContext _libraryContext;

        public Author GetAuthor(Guid authorId)
        {
            try
            {
                return _libraryContext.Authors.Where(a => a.AuthorId == authorId).FirstOrDefault();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public LibraryRepository(LibraryContext context)
        {
            _libraryContext = context;
        }

        public IEnumerable<Author> GetAllAuthor()
        {
            return _libraryContext.Authors.ToList();
        }

        public IEnumerable<Author> GetAuthorsByGenre(string genre)
        {
            return _libraryContext.Authors.Where(a => a.Genre == genre).ToList();
        }

        public Author PostAuthor(Author author)
        {
            try
            {
                if (_libraryContext != null)
                {
                    _libraryContext.Add(author);
                    _libraryContext.SaveChanges();
                    return author;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Author UpdateAuthor(Author author)
        {
            try
            {
                if (_libraryContext != null)
                {
                    _libraryContext.Update(author);
                    _libraryContext.SaveChanges();
                    return author;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int DeleteAuthor(Guid authorId)
        {
            try
            {
                if (_libraryContext != null)
                {
                    var author = _libraryContext.Authors.FirstOrDefault(x => x.AuthorId == authorId);
                    if (author != null)
                    {
                        _libraryContext.Remove(author);
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _libraryContext.Books.ToList();
        }

        IEnumerable<Author> ILibraryRepository<Author>.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Book> ILibraryRepository<Book>.GetAllAuthor()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Book> ILibraryRepository<Book>.GetAuthorsByGenre(string genre)
        {
            throw new NotImplementedException();
        }
    }
}

