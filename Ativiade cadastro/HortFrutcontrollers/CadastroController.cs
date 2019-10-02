

using System;
using System.Collections.Generic;
using Ativiade_cadastro.Models;

namespace Ativiade_cadastro.HortFrutcontrollers

{   
    public class Cadastro 
    {
         List<ProdutoModel> listaDeProdutos = new List<ProdutoModel>();
        public void CadastroProduto ()
        {
            System.Console.WriteLine("Digite o Nome do Produto");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite a categoria do produto");
            string categoria = Console.ReadLine();
            
            System.Console.WriteLine("Digite o preço");
            double preço =double.Parse(Console.ReadLine());

            System.Console.WriteLine("digite a quantidade em estoque");
            double estoque = double.Parse(Console.ReadLine());

            ProdutoModel Produto = new ProdutoModel();

            Produto.Id=listaDeProdutos.Count +1;
            Produto.Nome = nome;
            Produto.Categoria =categoria;
            Produto.Preço = preço;
            Produto.Estoque = estoque;
            Produto.DataDeCadastro = DateTime.Now;

            listaDeProdutos.Add(Produto);

        }
        public void ListaDeProdutos()
        {foreach (var item in listaDeProdutos)
        {
            System.Console.WriteLine($"Produto Id{item.Id}");
            System.Console.WriteLine($"Nome do Produto:{item.Nome}");
            System.Console.WriteLine($"Categoria do produto{item.Categoria}");
            System.Console.WriteLine($"Preço do produto: {item.Preço}");
            System.Console.WriteLine($"Quantidade em estoque{item.Estoque}");
            System.Console.WriteLine($"Hora que foi cadastrado{item.DataDeCadastro}");
        }

        }
        public void SomaDoEstoque()
        {   double total =0;
           
                foreach (var item in listaDeProdutos)
                {
                    
                  total = total +(item.Preço*item.Estoque);
                  System.Console.WriteLine($"total do valor de estoque é {total}");


                }
        }
    }
}