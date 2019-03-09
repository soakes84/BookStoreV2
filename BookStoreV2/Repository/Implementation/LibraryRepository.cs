using BookStoreV2.Entities;
using BookStoreV2.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreV2.Repository.Implementation
{
    public class LibraryRepository : ILibraryRepository<Author>
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
    }
}
