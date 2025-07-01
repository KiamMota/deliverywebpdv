namespace Domain.Core.Entities.Produto.Vo
{
    public class Estado
    {
        public enum EstadoEnum
        {
            PreparandoPedido = 0,
            EmRotaDeEntrega,
            FimDaEntrega,
        }

        private EstadoEnum _estado;

        public Estado(EstadoEnum estado) 
        {
            estado = _estado;
        }
    }
}
