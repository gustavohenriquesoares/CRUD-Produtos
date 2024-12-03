using System;
using System.Collections.Generic;
using CRUD.Classes;

namespace CRUD.Funcoes
{
    public static class ListarProdutos
    {
        public static void Executar(List<Produto> produtos)
        {
            Console.WriteLine("\n--- Produtos Cadastrados ---");

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.\n");
                return;
            }

            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.ID}, Nome: {produto.Nome}, Preço: {produto.Preco:C}, Categoria: {produto.Categoria}, Quantidade: {produto.Quantidade}");
            }
            Console.WriteLine();
        }
    }
}
