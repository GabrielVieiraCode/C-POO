using System;

namespace Atividade_POO.models
{
    public class Fone
    {
        public string cor {get; set;}

        public string marca {get; set;}

        public string Tamanho {get; set;}

        public void CadastrarFone(){
             
          System.Console.WriteLine("Digite a cor do fone");
          cor = Console.ReadLine();

          System.Console.WriteLine("Digite a marca do fone");
          marca = Console.ReadLine();

          System.Console.WriteLine("Digite o tamanho do Fone");
          Tamanho = Console.ReadLine();
        }

        
    }
    
}