namespace Infra.Data.Repositories.Base
{
    public interface IMapperBase<TDomain, TData>
    {
        TDomain ToDomain(TData data);
        TData ToData(TDomain domain);
    }
}
