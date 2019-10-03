namespace Game2.Models
{
    public class CapitaoModel : Base
    {
        public int Escudo { get; set; }


        public void LançarEscudo()
        {
            System.Console.WriteLine("Escudo Lancaçado!!");

        }

        public void Defender()
        {
            System.Console.WriteLine("Golpe denfendido");
        }
    }
}