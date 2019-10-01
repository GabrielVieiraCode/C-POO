using System;
using CadastroMVC.Controllers;

namespace CadastroMVC
{ /// <summary>Cadastro de usuario usando lista , csv e autenticaçao</summary>
    class Program
    { 
        static void Main(string[] args)
        {   //Estanciando objeto
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.CadastroUsuario();

            int opcao=0;
            do
            { System.Console.WriteLine("1- Cadastrar usuario");
            System.Console.WriteLine("2-   Listar Usuarios");
            System.Console.WriteLine("3- Autenticaçao");
            System.Console.WriteLine("0- Sair");
            opcao = int.Parse(Console.ReadLine());
            
                switch(opcao){
                    case 1:
                     usuarioController.CadastroUsuario ();

                        break;

                    case 2:
                        usuarioController.ListarUsuarios();
                        break;
                    case 3:
                    bool usuarioRetornado = usuarioController.Logar();
                    if(usuarioRetornado)
                    {
                        System.Console.WriteLine("Usuario localizado");
                    }
                    else
                    {
                        System.Console.WriteLine("Usuario nao encontrado");
                    }
                    break;    

                    case 0:
                        System.Console.WriteLine("Obrigado por usar o software");
                        break;

                    default:
                    System.Console.WriteLine("Opçao invalida");
                        break;
                }
            } while (opcao!=0);
        }
    }
}
