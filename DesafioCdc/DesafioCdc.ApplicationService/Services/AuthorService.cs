using DesafioCdc.ApplicationService.Requests;
using DesafioCdc.Domain.Entitites;
using DesafioCdc.Domain.Repositories;
using Newtonsoft.Json;

namespace DesafioCdc.ApplicationService.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task CreateAuthor(CreateAuthorRequest request)
        {
            try
            {
                Author author = new Author(request.Name, request.Email, request.Description);
                await _authorRepository.CreateAuthor(author);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
                throw;
            }
        }
    }
}
