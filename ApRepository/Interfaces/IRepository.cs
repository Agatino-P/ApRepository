using ApDdd;
using System.Collections.Generic;

namespace ApRepository.Interfaces
{
    public interface IRepository<T> where T : GuidEntity
    {
        IReadOnlyCollection<T> GetAll();
    }
}
