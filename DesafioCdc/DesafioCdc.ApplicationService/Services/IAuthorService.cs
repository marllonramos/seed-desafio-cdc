using DesafioCdc.ApplicationService.Requests;

namespace DesafioCdc.ApplicationService.Services
{
    public interface IAuthorService
    {
        Task CreateAuthor(CreateAuthorRequest request);
    }
}
