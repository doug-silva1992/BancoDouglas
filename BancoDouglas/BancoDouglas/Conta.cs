namespace BancoDouglas
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

        public void Depositar(double Valor)
        {
            this.Saldo += Valor;       
        }

        public virtual void Sacar(double Valor)
        {
            //if(Valor <= this.Saldo)
            //{
                this.Saldo -= Valor;
            //    return true;
            //}
            //return false;
        }
    }
}