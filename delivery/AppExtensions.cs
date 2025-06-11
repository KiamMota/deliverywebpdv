namespace Api.Extensions
{
    public static class BuilderAppExtensions
    {
        public static void EndPointPedidos(this WebApplication app)
        {
            var group = app.MapGroup("/api/pedidos");
            group.MapGet("/api/pedidos", (int id) =>
            {
                
            });
        }
    }

}
