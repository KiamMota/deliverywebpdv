using Domain.Core.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IProdutoRepo
    {
        long Salvar(Produto entity);
        Produto? GetById(long id);
        bool PutById(Produto entity, long id);
        bool DeleteById(long id);
        IList<Produto> ReadAll();
    }
}
