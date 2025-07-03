namespace Domain.Core.Entities.Produto.Vo
{
    public class EhDisponivel
    {
        public bool Disponibilidade { get; set; }
        public EhDisponivel(bool ehDisponivel)
        {
            if(ehDisponivel) Disponibilidade = true; Disponibilidade = false;
        }
    }
}
