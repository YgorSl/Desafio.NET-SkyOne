namespace Teste04
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (login == "")
            {                
                lblAvisos.Text = "O Login � obrigat�rio";
            }
            else if (senha == "")
            {               
                lblAvisos.Text = "A senha � obrigat�rio";
            }
            else
            {
                FrmNotas frmNotas = new FrmNotas();
                frmNotas.Show();
                Hide();
            }
        }
    }
}