using System;

namespace CRUD.Funcoes
{
    public static class Utils
    {
        public static int LerNumero(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out int numero))
                    return numero;

                Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
            }
        }

        public static decimal LerDecimal(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (decimal.TryParse(Console.ReadLine(), out decimal numero))
                    return numero;

                Console.WriteLine("Entrada inválida! Por favor, insira um número decimal.");
            }
        }
    }
}
