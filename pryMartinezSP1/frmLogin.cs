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
            if ((txtUsuario.Text == "Administrador" && txtContrase�a.Text == "adm123$") ||
                    (txtUsuario.Text == "Operador" && txtContrase�a.Text == "ope456$"))
            {

                this.Hide();
                frmBienvenida bienvenida = new frmBienvenida();
                bienvenida.ShowDialog();
                this.Show();
            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario o contrase�a incorrecta. Intento " + intentos + " de 3.");
                if (intentos >= 3)
                {
                    MessageBox.Show("Ha excedido el n�mero m�ximo de intentos. El programa se cerrar�.");
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