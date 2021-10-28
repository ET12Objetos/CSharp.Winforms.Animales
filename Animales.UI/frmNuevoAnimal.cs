using Animales.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animales.UI
{
    public partial class frmNuevoAnimal : Form
    {
        public Animal nuevoAnimal { get; set; }

        public frmNuevoAnimal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id, peso;
            string mensajeError = string.Empty;
            bool hayError = false;

            if (int.TryParse(txtId.Text, out id) == false)
            {
                mensajeError += "El id del animal es incorrecto \n";
                hayError = true;
            }

            if (int.TryParse(txtPeso.Text, out peso) == false)
            {
                mensajeError += "El peso del animal es incorrecto \n";
                hayError = true;
            }

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                mensajeError += "El nombre del animal es incorrecto \n";
                hayError = true;
            }

            if (hayError)
            {
                MessageBox.Show(mensajeError);
                return;
            }

            nuevoAnimal = new Animal()
            {
                id = Convert.ToInt32(txtId.Text),
                nombre = txtNombre.Text,
                peso = int.Parse(txtPeso.Text)
            };

            Close();
        }
    }
}
