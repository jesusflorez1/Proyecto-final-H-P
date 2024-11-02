namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //código login 
            //ingreso de usuario y contraseña 

            string usuario = TxtUsuario.Text;
            string contra = TxtContraseña.Text;

            //la funcion de esta condicion es confirmar los datos para poder iniciar a la biblioteca 

            if (usuario == "admin" && contra == "12345")
            {
                //con este messageBox nos aparece un mensaje de acceso correcto
                MessageBox.Show("Ingreso correctamente", "info", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //la funcion de estas 3 lineas de codigo, es para despues de iniciar sesion en el loguin, salte directamente a el siguiente formulario llamado biblioteca, con la funcion Formbiblioteca 
                //creamos la instacia que nos abrira el siguiente formulario 
                this.Hide();
                FormBiblioteca frm = new FormBiblioteca();
                frm.Show();
            }
            else
            {
                //con este messageBox nos aparece un mensaje de error, cuando ingresamos un dato erroneo 
                MessageBox.Show("Acceso Denegado","Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
