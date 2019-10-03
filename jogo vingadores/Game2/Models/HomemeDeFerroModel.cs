namespace Game2.Models
{
    public class HomemeDeFerroModel: Base
    {
        public int Armadura { get; set; }

        public void Voar()
        {
            System.Console.WriteLine("Voando");
        }

        public void Atirar ()
        {   
            System.Console.WriteLine("Atirando");
        }
    }
}