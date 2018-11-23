namespace CadastroCliente.Data.Entity
{
    public class ProdutoEntity
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
