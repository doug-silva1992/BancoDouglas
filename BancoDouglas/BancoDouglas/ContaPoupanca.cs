﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDouglas
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(double Saldo) : base(Saldo) { }
        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.10);
        }
    }
}
