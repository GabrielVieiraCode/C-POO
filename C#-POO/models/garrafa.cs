using System;

namespace Atividade_POO.models
{
    public class Garrafa
    {
        public string cor {get; set;}

        public string tamanho {get; set;}

        public string marca {get; set;}

        public void CadastrarGarrafa(){
           
         System.Console.WriteLine("Digite a cor da garrafa");

         cor = Console.ReadLine();

         System.Console.WriteLine("Digite a marca da garrafa");
         marca = Console.ReadLine();

         System.Console.WriteLine("Digite o tamanho da garrafa");
         tamanho = Console.ReadLine();
        }
    }
    

    
}