using System;
using System.Collections.Generic;
using CRUD.Classes;

namespace CRUD.Funcoes
{
    public static class AdicionarProduto
    {
        public static void Executar(List<Produto> produtos)
        {
            Console.WriteLine("\n--- Adicionar Produto ---");

            int id = Utils.LerNumero("ID: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            decimal preco = Utils.LerDecimal("Preço: ");
            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();
            int quantidade = Utils.LerNumero("Quantidade: ");

            produtos.Add(new Produto
            {
                ID = id,
                Nome = nome,
                Preco = preco,
                Categoria = categoria,
                Quantidade = quantidade
            });

            Console.WriteLine("Produto adicionado com sucesso!\n");
        }
    }
}
