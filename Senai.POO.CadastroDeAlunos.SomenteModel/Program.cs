using System;
using Senai.POO.CadastroDeAlunos.SomenteModel.Models;


namespace Senai.POO.CadastroDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando objeto
            AlunoModel aluno1 = new AlunoModel(); // Instânciando aluno
            
        
            Console.Clear(); // Limpa a tela

            aluno1.CadastrarAluno();

            aluno1.ListarAluno();

            aluno1.IrAoBanheiro();

        
        }
    }
}
