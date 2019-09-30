using System;

namespace Atividade_POO.models
{
    public class Caderno
    {
     public string cor {get; set;}

     public string quantidadedematerias {get; set;}

     public string marca {get; set;}
     
     public void CadastrarCaderno(){
         

     System.Console.WriteLine("Digite a cor do caderno");
     cor= Console.ReadLine();
                    
     System.Console.WriteLine("Digite a marca do seu caderno");
     marca = Console.ReadLine();
                    
     System.Console.WriteLine("Digite a quantidade de materias do caderno ");
     quantidadedematerias = Console.ReadLine();
     }

        
     }

    
    }

    
