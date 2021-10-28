using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animales.Core;

namespace Animales.UI
{
    public partial class frmAnimales : Form
    {
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void frmAnimales_Load(object sender, EventArgs e)
        {
            List<Animal> animales = new List<Animal>  {
               new Animal(1, "pato", 30), new Animal(5, "perro", 25),
               new Animal(9, "pájaro", 5), new Animal(10, "pez", 1),
               new Animal(2, "anguila", 10), new Animal(4, "gusano", 1),
               new Animal(3, "hormiga", 1), new Animal(42, "leon", 130),
               new Animal(12, "tigre", 90), new Animal(21, "escarabajo", 1),
               new Animal(33, "alce", 150), new Animal(34, "cebra", 90),
               new Animal(35, "jirafa", 200), new Animal(36, "jabalí", 170),
               new Animal(40, "mula", 50), new Animal(41, "burro", 70),
               new Animal(42, "oso", 150), new Animal(10, "papagayo", 15),
               new Animal(72, "rinoceronte", 800), new Animal(122, "foca", 80),
               new Animal(204, "mono", 30), new Animal(78, "conejo", 10),
               new Animal(10, "zorro", 25)
            };

            lstAnimales.Items.Clear();
            animales.ForEach(animal => lstAnimales.Items.Add(animal));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstAnimales.Items.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoAnimal formNuevoAnimal = new frmNuevoAnimal();
            formNuevoAnimal.ShowDialog();
            if (formNuevoAnimal.nuevoAnimal != null)
                lstAnimales.Items.Add(formNuevoAnimal.nuevoAnimal);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstAnimales.SelectedIndex > -1)
                lstAnimales.Items.Remove(lstAnimales.SelectedItem);
        }
    }
}
