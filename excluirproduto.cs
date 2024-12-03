using System;
using System.Collections.Generic;
using CRUD.Classes;

namespace CRUD.Funcoes
{
    public static class ExcluirProduto
    {
        public static void Executar(List<Produto> produtos)
        {
            Console.WriteLine("\n--- Excluir Produto ---");
            int id = Utils.LerNumero("Digite o ID do produto a ser excluído: ");

            var produto = produtos.Find(p => p.ID == id);
            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado!\n");
                return;
            }

            produtos.Remove(produto);
            Console.WriteLine("Produto excluído com sucesso!\n");
        }
    }
}
