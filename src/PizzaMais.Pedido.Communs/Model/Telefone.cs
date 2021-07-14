using PizzaMais.Pedido.Communs.Enum;

namespace PizzaMais.Pedido.Communs.Model
{
    public class Telefone : Base
    {
        public string Numero { get; set; }
        public bool Padrao { get; set; }
        public TipoNumero TipoNumero { get; set; }
    }
}
