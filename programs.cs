using System;
using System.Collections.Generic;
using CRUD.Classes;
using CRUD.Funcoes;

namespace CRUD
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main()
        {
            while (true)
            {
                ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarProduto.Executar(produtos);
                        break;
                    case "2":
                        ListarProdutos.Executar(produtos);
                        break;
                    case "3":
                        AtualizarProduto.Executar(produtos);
                        break;
                    case "4":
                        ExcluirProduto.Executar(produtos);
                        break;
                    case "5":
                        Console.WriteLine("Encerrando o programa. Até logo!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.\n");
                        break;
                }
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n======================");
            Console.WriteLine("      MENU CRUD       ");
            Console.WriteLine("======================");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Atualizar Produto");
            Console.WriteLine("4. Excluir Produto");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
        }
    }
}
