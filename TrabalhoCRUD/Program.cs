using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCRUD.Context;
using TrabalhoCRUD.Context.Models;

namespace TrabalhoCRUD
{
    class Program
    {
        static void Main()
        {
            ////para criar o banco
            //var context = new DistribuicaoContext();

            //foreach (var patrimonio in context.Patrimonios)
            //{
            //    Console.WriteLine(patrimonio.Equipamento);
            //}
            MenuTabelas();


            Console.ReadKey();
        }

        public static void MenuTabelas()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("============================");
                Console.WriteLine("PROJETO DISTRIBUIÇÃO ABINBEV");
                Console.WriteLine("============================\n\n");
                Console.WriteLine("Digite a opção desejada:\n");
                Console.WriteLine("1 - Funcionário");
                Console.WriteLine("2 - Centro Distribuição");
                Console.WriteLine("3 - Patrimônio");
                Console.WriteLine("4 - Sair");
                var opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 4)
                {
                    Console.WriteLine("Preesione a tecla Enter para sair...");
                    Console.ReadKey();
                    break;
                }
                string nomeTabela = "";

                if (opcao == 1)
                {
                     nomeTabela = "Funcionario";
                }
                else if (opcao == 2)
                {
                     nomeTabela = "Centro Distribuição";
                }
                else
                {
                     nomeTabela = "Patrimônio";
                }

                MenuCrud(opcao, nomeTabela);

            } while (true);

            
        }

        public static void MenuCrud(int opcao, string nomeTabela)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("============================");
                Console.WriteLine("PROJETO DISTRIBUIÇÃO ABINBEV");
                Console.WriteLine("============================\n\n");
                Console.WriteLine("Digite a opção desejada:\n");
                Console.WriteLine($"1 - Incluir {nomeTabela}");
                Console.WriteLine($"2 - Alterar {nomeTabela}");
                Console.WriteLine($"3 - Excluir {nomeTabela}");
                Console.WriteLine($"4 - Listar {nomeTabela}");
                Console.WriteLine($"5 - Listar 2 registros de {nomeTabela}");
                Console.WriteLine("6 - Sair");
                var opcaoTabela = Convert.ToInt32(Console.ReadLine());
                if (opcaoTabela == 6) break;

                switch (opcaoTabela)
                {
                    case 1:
                        //Cadastrar();
                        break;
                    case 2:
                        //Consultar();
                        break;
                    case 3:
                        //Remover();
                        break;
                    case 4:
                        // Consultar();
                        break;
                    case 5:
                        //ListarGeral.Executar(opcao);
                        break;
                }

                Console.WriteLine("Preesione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }


    }
}
