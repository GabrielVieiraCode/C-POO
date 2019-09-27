using System;
using Atividade_POO.models;

namespace Atividade_POO
{
    class Program
    {
        static void Main(string[] args)
        { 
            int res= 0;
            do{
            Console.WriteLine("Vamos cadastrar seus produtos");

                System.Console.WriteLine($@"
                Qual produto voce deseja cadastrar?
                1-Fone
                2-Garrafa
                3-Estojo
                4-Caderno");
                int res1 =int.Parse(Console.ReadLine());

                switch(res1){
                    case 1:
                    Fone fone = new Fone();
                   fone.CadastrarFone();
                   
                    break;

                    case 2:
                   Garrafa garrafa = new Garrafa();
                   garrafa.CadastrarGarrafa();
                  
                    break;

                    case 3:
                      Estojo estojo = new Estojo();
                      estojo.CadastrarEstojo();
                    
                  
                    break;

                    case 4:
                    Caderno caderno = new Caderno();
                    caderno.CadastrarCaderno();
                    break;

                }
            }while(res != 5);

            

            


        }
    }
}
