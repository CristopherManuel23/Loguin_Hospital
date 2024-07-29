namespace Loguin_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USER")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }
        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USER";
                txtusuario.ForeColor = Color.DimGray;
            }

        }
        private void txtcontrasenia_Enter(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "PASSWORD")
            {
                txtcontrasenia.Text = "";
                txtcontrasenia.ForeColor = Color.LightGray;
                txtcontrasenia.UseSystemPasswordChar = true;
            }
        }
        private void txtcontrasenia_Leave(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "")
            {
                txtcontrasenia.Text = "PASSWORD";
                txtcontrasenia.ForeColor = Color.DimGray;
                txtusuario.UseSystemPasswordChar = false;
            }

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "rzorrilla" && txtcontrasenia.Text == "12345" || txtusuario.Text == "Creadores" && txtcontrasenia.Text == "656794")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }


        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtcontrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
