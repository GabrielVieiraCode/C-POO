namespace Aula_POO_3.Models
{
    public class PessoaModel
    {
        public string Nome {get; set;}

        public int Idade {get; set;}

        public void comer (){
            System.Console.WriteLine("Vamos comer");


        }

        public void Andar(){
        System.Console.WriteLine("Vamos andar");
        }

        public void Dormir(){
            System.Console.WriteLine("Vamos dormir");
        }


    }
}