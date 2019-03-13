using BookStoreV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreV2.Repository.Contract
{
    public interface ILibraryRepository<T>
    {
        IEnumerable<T> GetAllAuthor();
        IEnumerable<T> GetAuthorsByGenre(string genre);
        Author GetAuthor(Guid authorId);
        Author PostAuthor(Author author);
        Author UpdateAuthor(Author author);
        int DeleteAuthor(Guid authorId);
    }
}
