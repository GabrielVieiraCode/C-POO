using System;

namespace Aula_POO_3.Models {
    public class FuncionarioModel : PessoaModel {
        public FuncionarioModel (string cargo) {
            this.Cargo = cargo;

        }

        public FuncionarioModel()
        {
        }

        public string Cargo { get; set; }

        public void Trabalhar () {
            System.Console.WriteLine ("Agora vamos trabalhar");

        }
        public void Cadastrarfuncionario () {
            System.Console.WriteLine ("Digite o nome do funcionario");
            Nome = Console.ReadLine ();

            System.Console.WriteLine ("Digite a idade do funcionario");
            Idade = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o cargo do funcionario");
            Cargo = Console.ReadLine ();
        }

    }
}