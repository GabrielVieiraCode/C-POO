using System;

namespace Atividade_POO.models
{
    public class Estojo
    {
        public string cor {get; set;}

        public string tamanho {get; set;}

        public string marca {get; set;}

         public void CadastrarEstojo(){
       
     System.Console.WriteLine("Digite a cor do estojo");
     cor = Console.ReadLine();
                    
     System.Console.WriteLine("Digite o tamanho do estojo");
     tamanho= Console.ReadLine();

     System.Console.WriteLine("Digite a marca do estojo");
     marca = Console.ReadLine();

         
    }

    
}
}