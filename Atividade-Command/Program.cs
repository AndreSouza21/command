using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();
        
            Dictionary<string, Command> comandos = new Dictionary<string, Command>
            {
                { "new",    new NewPessoa(db) },
                { "delete", new DelPessoa(db) },
                { "all",    new All(db)        },
                { "get",    new Get(db)        }
            };
        
            Console.WriteLine("=== Banco de Pessoas ===");
            Console.WriteLine("Comandos: new <id> <nome> | delete <id> | all | get <id> | exit\n");
        
            while (true)
            {
                Console.Write("\n> ");
                string linha = Console.ReadLine().Trim();
        
                if (linha == "exit")
                    break;
        
                string[] partes = linha.Split(' ');
                string nomeComando = partes[0].ToLower();
                string[] parametros = partes.Skip(1).ToArray();
        
                if (!comandos.ContainsKey(nomeComando))
                {
                    Console.WriteLine("Comando não encontrado.");
                    continue;
                }
        
                object resultado = comandos[nomeComando].Execute(parametros);
        
                switch (nomeComando)
                {
                    case "new":
                        Console.WriteLine("Pessoa inserida.");
                        break;
                    case "delete":
                        Console.WriteLine("Pessoa removida.");
                        break;
                    case "all":
                        break;
                    case "get":
                        Pessoa p = (Pessoa)resultado;
                        Console.WriteLine($"id={p.GetPessoaId()}, nome={p.GetPessoaNome()}");
                        break;
                }
            }
        
        }
    }
}
