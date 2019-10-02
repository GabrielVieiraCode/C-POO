using System;

namespace Ativiade_cadastro.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public double Preço {get; set;}

        public double Estoque {get; set;}

        public DateTime DataDeCadastro {get; set;}
    }
}