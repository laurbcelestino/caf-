using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace grãoesabor_cafeteria
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int opcao = 0;
            while (opcao != 5) // != diferente 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
░█████╗░░█████╗░███████╗███████╗████████╗███████╗██████╗░██╗░█████╗░
██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔════╝██╔══██╗██║██╔══██╗
██║░░╚═╝███████║█████╗░░█████╗░░░░░██║░░░█████╗░░██████╔╝██║███████║
██║░░██╗██╔══██║██╔══╝░░██╔══╝░░░░░██║░░░██╔══╝░░██╔══██╗██║██╔══██║
╚█████╔╝██║░░██║██║░░░░░███████╗░░░██║░░░███████╗██║░░██║██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═╝░░░░░╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝╚═╝░░╚═╝");

                Console.ResetColor();
                Console.WriteLine("\n 1 - Cadastro de Produtos");
                Console.WriteLine("\n 2 - Cadastro de Clientes");
                Console.WriteLine("\n 3 - Cadastro de Funcionario");
                Console.WriteLine("\n 4 - Cadastro de Cardapio");
                Console.WriteLine("\n 5 - Cadastro de Fornecedores");
                Console.WriteLine("\n 6 - Sair");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite a opção escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cadastroprodutos();
                        break;
                    case 2:
                        cadastrocliente();
                        break;
                    case 3:
                        cadastrofuncionario();
                        break;
                    case 4:
                        cadastrocardapio();
                        break;
                    case 5:
                        cadastrofornecedores();
                        break;
                    case 6:
                        encerramento();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Opção Invalida!!");
                        Console.ResetColor();
                        Thread.Sleep(2000); // pausa na programação por 2s

                        break;
                }
            }
        } 

          static void cadastroprodutos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗████████╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║╚══██╔══╝██╔══██╗██╔════╝
██████╔╝██████╔╝██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║╚█████╗░
██╔═══╝░██╔══██╗██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║░╚═══██╗
██║░░░░░██║░░██║╚█████╔╝██████╔╝╚██████╔╝░░░██║░░░╚█████╔╝██████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═════╝░░╚═════╝░░░░╚═╝░░░░╚════╝░╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n Qual o nome do produto?: ");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("\n Validade do produto:");
            string validadeproduto = Console.ReadLine();
            Console.WriteLine("\n Qual o valor do produto?: ");
            string valorproduto = Console.ReadLine(); 
            Console.WriteLine("\n Qual o peso do Produto?: ");
            string pesoproduto = Console.ReadLine();
            Console.WriteLine("\n QTD de Produto?: ");
            int qtdproduto = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdproduto; i++) 
            {
                Console.WriteLine($"\n quantidade do {i} Produto:");
                string quantidadeproduto = Console.ReadLine();
            }
            Console.WriteLine("\n Qual o número de lote?:");
            string numerolote = Console.ReadLine();
            Console.WriteLine("\n Cadastro Finalizado!!");
            Thread.Sleep(2000);
        } 
        static void cadastrocliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();
            Console.WriteLine("\n Qual o nome do cliente: ");
            string nomecliente = Console.ReadLine();
            Console.WriteLine("\n Número do Cliente: ");
            string numerocliente = Console.ReadLine();
            Console.WriteLine("\n CPF do cliente: ");
            string cpfcliente = Console.ReadLine();
            Console.WriteLine("\n Email do Cliente:");
            string emailcliente = Console.ReadLine();
            Console.WriteLine("\n Endereço do Cliente:");
            string enderecocliente = Console.ReadLine();
            Console.WriteLine("\n Telefone de Contato:");
            string telefonecontato = Console.ReadLine();
            Console.WriteLine("\n Cadastro Finalizado!!");
            Thread.Sleep(2000);
        }
          static void cadastrofuncionario()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██████╗░██╗░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██╔══██╗██║██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██████╔╝██║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██║██║░░██║██║╚████║██╔══██║██╔══██╗██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░░██║██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░");
            Console.ResetColor();
            Console.WriteLine("\n Qual o nome do Funcionario?: ");
            string nomefuncionario = Console.ReadLine();
            Console.WriteLine("\n CPF do Funcionario: ");
            string cpffuncionario = Console.ReadLine();
            Console.WriteLine("\n CEP do Funcionario: ");
            string cepfuncionario = Console.ReadLine();
            Console.WriteLine("\n Telefone do funcionario: ");
            string telefonefuncionario = Console.ReadLine();
            Console.WriteLine("\n Qual a sua função? ");
            string funcaofuncionario = Console.ReadLine(); 
            Console.WriteLine("\n Data de Nascimento do Funcionario: ");
            string datanascimento = Console.ReadLine(); 
            Console.WriteLine("\n Cadastro Finalizado!!");
            Thread.Sleep(2000); 
        }
           static void cadastrocardapio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░██████╗░░█████╗░██████╗░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗
██║░░╚═╝███████║██████╔╝██║░░██║███████║██████╔╝██║██║░░██║
██║░░██╗██╔══██║██╔══██╗██║░░██║██╔══██║██╔═══╝░██║██║░░██║
╚█████╔╝██║░░██║██║░░██║██████╔╝██║░░██║██║░░░░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.WriteLine("\n Nome: ");
            string nomecardapio = Console.ReadLine();
            Console.WriteLine("\n Descrição Do Cardapio: ");
            string descricaocardapio = Console.ReadLine();
            Console.WriteLine("\n Valor do cardapio: ");
            string valorcardapio = Console.ReadLine();
            Console.WriteLine("\n QTD Igredientes: ");
            int qtdigredientes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdigredientes; i++)
            {
                Console.WriteLine($"\n quantidade de {i} igredientes :");
                string quantidadeproduto = Console.ReadLine();
            }
            Console.WriteLine("\n QTD adicionais para o cardapio: ");
            int qtdadicionais = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdadicionais; i++)
            {
                Console.WriteLine($"\n quantidade de {i} adicionais:");
                string quantidadeproduto = Console.ReadLine();
            }
                Console.WriteLine("\n Cadastro Finalizado!!");
            Thread.Sleep(2000);
        }
           static void cadastrofornecedores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░███████╗░██████╗
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝█████╗░░╚█████╗░
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗██╔══╝░░░╚═══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║███████╗██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n Nome dos fornecedores: ");
            string nomefornecedores = Console.ReadLine();
            Console.WriteLine("\n Telefone de Contato: ");
            string telefonecontato = Console.ReadLine();
            Console.WriteLine("\n Endereço: ");
            string endereçofornecedores = Console.ReadLine();
            Console.WriteLine("\n CNPJ: ");
            string cnpjfornecedores = Console.ReadLine();
            Console.WriteLine("\n Data de nascimento: ");
            string datanascimento = Console.ReadLine();
            Console.WriteLine("\n PIX");
            string pixfornecedor = Console.ReadLine();
            Console.WriteLine("\n Cadastro Finalizado!!");
            Thread.Sleep(2000); 
        } 
        static void encerramento()
        {
            Console.WriteLine("\n O seu programa foi encerrado.");
            Thread.Sleep(2000); 
        }
    }
}
