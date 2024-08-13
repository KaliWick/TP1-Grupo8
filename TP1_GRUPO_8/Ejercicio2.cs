using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_8
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim()!="" && txtNombre.Text.Trim()!="")
            {
                lblNombre.Text.Trim();
                lblApellido.Text.Trim();
                lbLista.Items.Add(txtNombre.Text + " " + txtApellido.Text);
            }
        }
    }
}
