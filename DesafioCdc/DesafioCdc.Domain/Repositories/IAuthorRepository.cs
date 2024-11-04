using DesafioCdc.Domain.Entitites;

namespace DesafioCdc.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Task CreateAuthor(Author author);
    }
}
