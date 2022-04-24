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

        private void Sacar_Click_Click(object sender, EventArgs e)
        {
            double valorSacar = Convert.ToDouble(textValor.Text);
            if(conta.Sacar(valorSacar))
            {
                textSaldo.Text = Convert.ToString(conta.Saldo);
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void Depositar_Click_Click(object sender, EventArgs e)
        {
            double valorDepositar = Convert.ToDouble(textValor.Text);
            conta.Depositar(valorDepositar);
            textSaldo.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show("Sucesso");
        }
    }
}