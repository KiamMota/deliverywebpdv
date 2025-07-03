using System.Numerics;

namespace AppService.Interfaces
{
    public interface IProcessData<TRequest> where TRequest : class
    {
        public long Salvar(TRequest entity);
        public TRequest GetById(long id);
        public bool DeleteById(long id);
        public bool PutById(TRequest entity, long id);
    }
}
