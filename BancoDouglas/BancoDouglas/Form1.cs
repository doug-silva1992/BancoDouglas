namespace BancoDouglas
{
    public partial class Banco : Form
    {
        private Conta conta;
        private Cliente cliente;
        public Banco()
        {
            InitializeComponent();
        }

        private void Banco_Load(object sender, EventArgs e)
        {
            this.conta = new Conta(100.00);
            this.cliente = new Cliente("Douglas");
            conta.Numero = 1;
            conta.Titular = cliente;

            textTitular.Text = conta.Titular.Nome;
            textNumero.Text = Convert.ToString(conta.Numero);
            textSaldo.Text = Convert.ToString(conta.Saldo);
        }
    }
}