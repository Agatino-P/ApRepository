using ApDdd;

namespace ApRepository.Interfaces
{
    public interface IGuidRepository<T> : IRepository<T> where T : GuidEntity
    {
    }
}
