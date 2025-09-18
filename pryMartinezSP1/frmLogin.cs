namespace pryMartinezSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" && txtContraseña.Text == "adm123$") ||
                    (txtUsuario.Text == "Operador" && txtContraseña.Text == "ope456$"))
            {

                this.Hide();
                frmBienvenida bienvenida = new frmBienvenida();
                bienvenida.ShowDialog();
                this.Show();
            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario o contraseña incorrecta. Intento " + intentos + " de 3.");
                if (intentos >= 3)
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos. El programa se cerrará.");
                    this.Close();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("El texto del usuario ha cambiado." + txtUsuario);
        }   
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }   





    }
}