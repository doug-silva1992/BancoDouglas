﻿namespace BancoDouglas
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta(double Valor)
        {
            this.Saldo = Valor;
        }
    }
}