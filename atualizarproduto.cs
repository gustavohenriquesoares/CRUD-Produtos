using System;
using System.Collections.Generic;
using CRUD.Classes;

namespace CRUD.Funcoes
{
    public static class AtualizarProduto
    {
        public static void Executar(List<Produto> produtos)
        {
            Console.WriteLine("\n--- Atualizar Produto ---");
            int id = Utils.LerNumero("Digite o ID do produto a ser atualizado: ");

            var produto = produtos.Find(p => p.ID == id);
            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado!\n");
                return;
            }

            Console.Write("Novo Nome: ");
            produto.Nome = Console.ReadLine();
            produto.Preco = Utils.LerDecimal("Novo Preço: ");
            Console.Write("Nova Categoria: ");
            produto.Categoria = Console.ReadLine();
            produto.Quantidade = Utils.LerNumero("Nova Quantidade: ");

            Console.WriteLine("Produto atualizado com sucesso!\n");
        }
    }
}
