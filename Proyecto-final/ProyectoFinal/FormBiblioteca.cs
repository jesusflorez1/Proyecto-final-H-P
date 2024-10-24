using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormBiblioteca : Form
    {
        public FormBiblioteca()
        {
            InitializeComponent();
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {
            //código biblioteca principal
            //programamos el boton buscar libro 

            //creamos cada vector con los datos suministrados 

            string[] VecNomLibros = { "El viejo y el mar", "Viaje al centro de la tierra", "Harry Potter", "Don Quijote de la mancha " };
            string[] VecAutor = { "Ernest Hemingway", "Julio Verne", "J.K: Rowling", "Miguel De Cervantes" };
            string[] VecUbicacion = { "A1", "B1", "A1", "B1" };
            int[] VecCantLibros = { 17, 13, 8, 11 };

            //se crea la variable para seleccionar el valor del indice del comboBox que inicia desde 0
            int indice = CbBuscarLibro.SelectedIndex;
            //a cada textBox se le asigna un vector. despues de seleccionar el valor del indice mostrara los datos en los textBox's
            TxtLibrosEncontrados.Text = VecNomLibros[indice];
            TxtAutor.Text = VecAutor[indice];
            TxtUbicacion.Text = VecUbicacion[indice];
            //este textBox ya que es valor entero, se convierte a string por medio de ToString
            TxtCantidadLibros.Text = VecCantLibros[indice].ToString();

            MessageBox.Show("Busqueda exitosa", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBuscarAutor_Click(object sender, EventArgs e)
        {
            //programamos el boton buscar autor 

            //creamos cada vector con los datos suministrados 
            string[] VecNomLibros = { "El viejo y el mar", "Viaje al centro de la tierra", "Harry Potter", "Don Quijote de la mancha " };
            string[] VecAutor = { "Ernest Hemingway", "Julio Verne", "J.K: Rowling", "Miguel De Cervantes" };
            string[] VecUbicacion = { "A1", "B1", "A1", "B1" };
            int[] VecCantLibros = { 2, 3, 8, 10 };

            //se crea la variable para seleccionar el valor del indice del comboBox que inicia desde 0 
            int indice = CbBuscarAutor.SelectedIndex;
            //a cada textBox se le asigna un vector. despues de seleccionar el valor del indice mostrara los datos en los textBox's
            TxtLibrosEncontrados.Text = VecNomLibros[indice];
            TxtAutor.Text = VecAutor[indice];
            TxtUbicacion.Text = VecUbicacion[indice];
            //este textBox ya que es valor entero, se convierte a string por medio de ToString
            TxtCantidadLibros.Text = VecCantLibros[indice].ToString();

            MessageBox.Show("Busqueda exitosa", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
