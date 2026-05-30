using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario_P1
{
    public class CuentaBancaria
    {
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; private set; }

        public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
        {
            NumeroCuenta = numeroCuenta;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0) throw new ArgumentException("El monto debe ser mayor a cero");
            Saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            if (monto <= 0) throw new ArgumentException("El monto debe ser mayor a cero");
            if (monto > Saldo) throw new InvalidOperationException("Fondos insuficientes");
            Saldo -= monto;
        }
    }
}
