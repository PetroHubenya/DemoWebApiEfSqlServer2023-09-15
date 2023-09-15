using Models;

namespace Interfaces
{
    public interface IBoxService
    {
        Task<List<Box>> GetAsync();
    }
}