using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema Bancario .NET 4.7.2 Iniciado ---");

            // Instanciamos el ejemplo para que el ejecutable sea válido
            CuentaBancaria cuenta = new CuentaBancaria("123456", 100);
            cuenta.Depositar(50);

            Console.WriteLine("Prueba de consola exitosa. Saldo actual: " + cuenta.Saldo);
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
