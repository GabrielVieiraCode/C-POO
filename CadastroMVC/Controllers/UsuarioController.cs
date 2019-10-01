using System;
using System.Collections.Generic;
using CadastroMVC.Models;

namespace CadastroMVC.Controllers
{
    public class UsuarioController
    {/// <summary>Metodo pata cadastro de usuario</summary>
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            public void CadastroUsuario ()
            {
                System.Console.WriteLine("Digite o seu nome");
                string nome = Console.ReadLine();

                System.Console.WriteLine("Digite seu  seu email");
                string email = Console.ReadLine();
                
                System.Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                
                //Instanciando um novo usuario
                UsuarioModel usuario = new UsuarioModel();

                //Populando o objeto
                usuario.Id = listaDeUsuarios.Count +1;
                usuario.Nome = nome;
                usuario.Email = email;
                usuario.DataCriacao = DateTime.Now;
                usuario.Senha = senha;

                listaDeUsuarios.Add(usuario);


            }// Fim cadastro de usuario

            public void ListarUsuarios()
            {
                foreach (var item in listaDeUsuarios)
                {    System.Console.WriteLine("====================");
                    System.Console.WriteLine($"Usuario: {item.Nome}");
                    System.Console.WriteLine($"Id{item.Id}");
                    System.Console.WriteLine($"Email:{item.Email}");
                    System.Console.WriteLine("=====================");
                }
            }// Fim listaUsuarios

            public bool Logar()
            {
                System.Console.WriteLine("Digite seu email");
                string email = Console.ReadLine();
                
                System.Console.WriteLine("Insia sua senha");

                string senha = Console.ReadLine();
                foreach (var item in listaDeUsuarios)
                {
                    if(item.Email == email && item.Senha == senha)
                    {
                      
                        return true;
                    
                    }
                }// Fim foreach
                return false;
            }//Fim logar
    }
}