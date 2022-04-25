namespace BancoDouglas
{
    public partial class Banco : Form
    {
        private Conta[] contas;
        private ContaPoupanca contaPoupanca;
        private Cliente cliente;
        public Banco()
        {
            InitializeComponent();
        }

        private void Banco_Load(object sender, EventArgs e)
        {
            this.contas[0] = new Conta(100.00);
            this.contas[0].Titular = new Cliente("Douglas");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaCorrente(200.00);
            this.contas[1].Titular = new Cliente("Denis");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaPoupanca(300.00);
            this.contas[2].Titular = new Cliente("Daniel");
            this.contas[2].Numero = 3;

        }

        private void Sacar_Click_Click(object sender, EventArgs e)
        {
            //double valorSacar = Convert.ToDouble(textValor.Text);
            //if(conta.Sacar(valorSacar))
            //{
            //    textSaldo.Text = Convert.ToString(conta.Saldo);
            //    MessageBox.Show("Sucesso");
            //}
            //else
            //{
            //    MessageBox.Show("Saldo Insuficiente");
            //}
        }

        private void Depositar_Click_Click(object sender, EventArgs e)
        {
            //double valorDepositar = Convert.ToDouble(textValor.Text);
            //conta.Depositar(valorDepositar);
            //textSaldo.Text = Convert.ToString(conta.Saldo);
            //MessageBox.Show("Sucesso");
        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textIndice.Text);
            Conta selecionada = this.contas[indice];
            textNumero.Text = Convert.ToString(selecionada.Numero);
            textTitular.Text = selecionada.Titular.Nome;
            textSaldo.Text = Convert.ToString(selecionada.Numero);
        }
    }
}