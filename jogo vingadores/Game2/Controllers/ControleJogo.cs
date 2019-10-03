using System;
using Game2.Models;

namespace Game2.Controllers
{
    public class ControleJogo
    {
        public void Luta()
        {
            CapitaoModel Capitao=  new CapitaoModel();
            HomemeDeFerroModel homemDeFerro= new HomemeDeFerroModel();
            Thanos thanos = new Thanos();


             
           
        }
            public void ControleHferro()
            {  
                int acao;
                 do{

                 HomemeDeFerroModel homemDeFerro = new HomemeDeFerroModel();
                 Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Decida o que o Homem de ferro fara");
                System.Console.WriteLine("Digite voar para ele Voar");
                System.Console.WriteLine("Digite 2 para atirar");
                 System.Console.WriteLine("Digite 3 para escolher outro heroi");
                acao = int.Parse(Console.ReadLine());
                switch (acao)
                
                {   case 1:
                    
                    homemDeFerro.Voar();
                    break;

                    case 2:
                    homemDeFerro.Atirar();
                    break;
                    
                    default:
                    
                    System.Console.WriteLine("Voce deu o comando errado, Thanos ganhou mas nao desista tente novamente");
                    break;
                
                    
                }
                Console.ResetColor(); }while(acao!=3);

                Console.ResetColor();

                


            }

            public void ControleCapAmerica()
            { 
                int acao;
                 do{

                 Console.ForegroundColor = ConsoleColor.Blue;
                 CapitaoModel Capitao = new CapitaoModel();
                System.Console.WriteLine("Decida o que o Homem de ferro fara");
                System.Console.WriteLine("Digite 1  para ele jogar o escudo");
                System.Console.WriteLine("Digite 2 para se defender");
                 System.Console.WriteLine("Digite 3 para escolher outro heroi");
               
                acao = int.Parse(Console.ReadLine());
                switch (acao)
                {   case 1:
                    
                    Capitao.LançarEscudo();
                    break;

                    case 2:
                    Capitao.Defender();
                    break;
                    
                    default:
                  
                    System.Console.WriteLine("Voce deu o comando errado, Thanos ganhou mas nao desista tente novamente");
                    break;
                    
                }
                 Console.ResetColor();}while(acao!=3);
                 Console.ResetColor();
                
            }
    }
}