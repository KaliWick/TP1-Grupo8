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
            bool isDup = false;
            string nuevoNombre = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();

            foreach (var item in lbLista.Items)
            {
                if (item.ToString().ToUpper().Trim() == nuevoNombre.ToUpper())
                {
                    isDup = true;
                    break;
                }
            }

            if (isDup)
            {
                MessageBox.Show("Esa persona ya esta registrada");
            }
            else if (txtApellido.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un nombre y un apellido");
            }
            else if (txtNombre.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if(txtApellido.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese un apellido");
            }
            else
            {
                lbLista.Items.Add(nuevoNombre);

                txtNombre.Text = "";
                txtApellido.Text = "";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            if (lbLista.SelectedItems.Count==0)
            {
                MessageBox.Show("Debe seleccionar un Item");
            }
            else
            {
                lbLista.Items.Remove(lbLista.SelectedItem);
            }
        }
        //hover boton registrar
        private void btnRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegistrar.BackColor = Color.LightBlue;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = SystemColors.InactiveBorder;
        }
        //hover boton borrar
        private void btnBorrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnBorrar.BackColor = Color.LightBlue;
        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            btnBorrar.BackColor = SystemColors.InactiveBorder;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}