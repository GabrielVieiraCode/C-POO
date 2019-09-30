using System;
using Aula_POO_3.Models;

namespace Aula_POO_3
{
    class Program
    {
        static void Main(string[] args)
        {   //Descriçao da atividade
            Console.WriteLine("Aula POO herança");
          
            // estanciando o objeto
            FuncionarioModel funcionario =  new  FuncionarioModel();

            // declarando Variavel opçao
            int opcao;

            //Inicio do laço
            do
            {   // Criando menu de opçoes
                 System.Console.WriteLine("Escolha uma opçao");

            System.Console.WriteLine($@"
            1- Cadastrar funcionario
            2- Executar açoes
            0- Sair
            ");
            //lendo valor digitado e armazenando no variavel opçao
            opcao =int.Parse(Console.ReadLine());

            //Inicio do switch opçao
            switch (opcao){
                case 1:
                // Cadastrando
                funcionario.Cadastrarfuncionario();
               
                break;

                case 2:
                // Declarando a variavel açao
                int acao;
                do
                {// Criando o menu de açao do funcionario
                     System.Console.WriteLine($@"
                Escolha uma das açoes para o funcionario {funcionario.Nome}
                1- Andar
                2- Comer
                3- Dormir
                0- Sair
                
                ");
                // armazenando valor digitado na variavel açao
                acao =int.Parse(Console.ReadLine());
                
                switch(acao){// Inicio do switch açao
                    case 1:
                    //Executar
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
                }// Fim do switch açao


                }while(acao!=0);

                break;

                case 0:
                break;

                default:
                    System.Console.WriteLine("opçao invalida");
                break;


            }//Fim do switch opçao
            


            }while(opcao !=0);
        }
    }
}
