namespace CadastroCliente.Domain.Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public bool PossuiEstoque
        {
            get
            {
                // operador condicional ternário
                return Quantidade == 0 ? false : true;
            }
        }
    }
}
