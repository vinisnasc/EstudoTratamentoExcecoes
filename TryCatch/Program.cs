using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o saldo: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o limite de retirada: ");
            double limite = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto deseja sacar? ");
            double saque = double.Parse(Console.ReadLine());

            try
            {
                if (saque > limite)
                    throw new OverflowException();
                if (saque > saldo)
                    throw new Exception();
                Console.WriteLine($"Novo saldo de {saldo - saque}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Operação negada!Seu limite é de: {limite} por dia!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Operação negada!Seu saldo é de: {saldo}!");
            }
            finally
            {
                Console.WriteLine("Adeus!");
            }
        }
    }
}
