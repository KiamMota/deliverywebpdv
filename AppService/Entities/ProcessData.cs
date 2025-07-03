using AppService.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace AppService.Entities
{
    public class ProcessData<TRequest> : IProcessData<TRequest> where TRequest : class
    {
        private readonly 
        public bool DeleteById(long id)
        {
            
        }

        public TRequest GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool PutById(TRequest entity, long id)
        {
            throw new NotImplementedException();
        }

        public long Salvar(TRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}
