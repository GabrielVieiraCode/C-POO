using System;
using Ativiade_cadastro.HortFrutcontrollers;

namespace Ativiade_cadastro
{
    class Program
    {
        static void Main(string[] args)
        {  Cadastro cadastro = new Cadastro();
            int opcao = 0;
           do
           { System.Console.WriteLine("Digite uma das opçoes");
             System.Console.WriteLine("1- Para cadastrar Produto");
            System.Console.WriteLine("2- para listar Produtos");
            System.Console.WriteLine("3- para somar o preço dos produtos em estoque");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {case 1: 
                cadastro.CadastroProduto();
            break;

            case 2:
                cadastro.ListaDeProdutos();
            break;

            case 3:
                cadastro.SomaDoEstoque();
            break;

            default:
                System.Console.WriteLine("Opçao invalida");

            break;


            }
          
           } while (opcao!=0);
        }
    }
}
