using System;

namespace CadastroCliente.Domain.Model
{
    /// <summary>
    /// Modelo de Negócios
    /// </summary>
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Idade
        {
            get
            {
                return Convert.ToInt32(DateTime.Now.Date.Subtract(DataNascimento.Date).TotalDays / 365);
            }
        }
    }
}
