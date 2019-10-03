using System;
using Game2.Controllers;
using Game2.Models;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {    
             int opcao;
             ControleJogo controle = new ControleJogo();
             do
            {  
                Console.ForegroundColor = ConsoleColor.Yellow;
                 System.Console.WriteLine("Escolha seu Heroi!!");
                System.Console.WriteLine("1-Homem de Ferro");
                System.Console.WriteLine("2-Capitao America");
                System.Console.WriteLine("Digite 3 para sair");
                opcao = int.Parse(Console.ReadLine());
               
                 Console.ResetColor();
                
                switch(opcao)
                {   case 1:
                    controle.ControleHferro();
                    
                    break;

                    case 2:
                    
                    controle.ControleCapAmerica();

                    break;
                    default:
                    System.Console.WriteLine("Voce deu o comando errado, Thanos ganhou mas nao desista tente novamente");
                    break;

                }
                
            } while (opcao!=3);


        }
    }
}
