using Domain.Core.Entities;
using Infra.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Infra.Data.Repositories
{
    public class RepoEstabelecimento : ICrudBase<RepoEstabelecimento>
    {
        public int Create(RepoEstabelecimento entity)
        {
            
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<RepoEstabelecimento> ReadAll()
        {
            throw new NotImplementedException();
        }

        public RepoEstabelecimento ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateById(RepoEstabelecimento newEntity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
