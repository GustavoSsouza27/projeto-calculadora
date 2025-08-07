namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo está vazio ou só tem espaços!");
            }
            

            //Verifica se os campos de entrada estão preenchidas
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);


            //verifica a soma das variaveis
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo está vazio ou só tem espaços!");
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas números válidos! Letras não são permitidas.");
                return;
            }

            _ = Convert.ToDouble(txtNumero1.Text);
            _ = Convert.ToDouble(txtNumero2.Text);


            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo está vazio ou só tem espaços!");
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas números válidos! Letras não são permitidas.");
                return;
            }

            _ = Convert.ToDouble(txtNumero1.Text);
            _ = Convert.ToDouble(txtNumero2.Text);


            lblResultado.Text = (numero1 * numero2).ToString();


        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo está vazio ou só tem espaços!");
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Digite apenas números válidos! Letras não são permitidas.");
                return;
            }

            _ = Convert.ToDouble(txtNumero1.Text);
            _ = Convert.ToDouble(txtNumero2.Text);
            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
