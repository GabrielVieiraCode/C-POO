using System;
using Aula_POO_3.Models;

namespace Aula_POO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula POO herança");

            FuncionarioModel func = new FuncionarioModel();

            FuncionarioModel funcionario =  new  FuncionarioModel();

            
            int opcao;
            
            do
            { System.Console.WriteLine("Escolha uma opçao");

            System.Console.WriteLine($@"
            1- Cadastrar funcionario
            2- Executar açoes
            0- Sair
            ");
            opcao =int.Parse(Console.ReadLine());

            switch (opcao){
                case 1:
                funcionario.Cadastrarfuncionario();
               
                break;

                case 2:
                int acao;
                do
                { System.Console.WriteLine($@"
                Escolha uma das açoes para o funcionario {funcionario.Nome}
                1- Andar
                2- Comer
                3- Dormir
                0- Sair
                
                ");
                acao =int.Parse(Console.ReadLine());
                
                switch(acao){
                    case 1:
                    funcionario.Andar();
                    

                    break;

                    case 2:
                    funcionario.comer();

                    break;

                    case 3:
                    funcionario.Dormir();
                    break;

                    case 0:
                        System.Console.WriteLine("Muito obrigado por usar o software");
                    break;

                    default:
                    System.Console.WriteLine("opçao invalida");
                    break;
                }


                }while(acao!=0);

                break;

                case 0:
                break;

                default:
                    System.Console.WriteLine("opçao invalida");
                break;


            }
            


            }while(opcao !=0);
        }
    }
}
