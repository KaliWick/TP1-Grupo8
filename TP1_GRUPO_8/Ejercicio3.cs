using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_8
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            string selection;
            selection = "Usted selecciono los siguientes elementos:" + "\n\r";
            selection += "Sexo: " + (string)(rbFemenino.Checked ? "Femenino" : "Masculino") + "\n\r";
            selection += "Estado Civil: " + (string)(rbCasado.Checked ? "Casado" : "Soltero") + "\n\r";
            selection += "Oficio: " + "\n\r";
            for (int i = 0; i < clbOficio.CheckedItems.Count; i++)
            {
                selection += "-" + clbOficio.CheckedItems[i].ToString() + "\n\r";
            }
            lblSeleccion.Text = selection;
        }

        private void gbSexo_Enter(object sender, EventArgs e)
        {

        }

        private void btnSeleccion_MouseMove(object sender, MouseEventArgs e)
        {
            btnSeleccion.BackColor = Color.DimGray;
        }

        private void btnSeleccion_MouseLeave(object sender, EventArgs e)
        {
            btnSeleccion.BackColor = Color.DimGray;
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
