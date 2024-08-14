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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        //Cargar nombres
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text.Trim();
            bool iguales = false;

            foreach(string n in lbNombres1.Items)
            {
                if(nuevoNombre.ToUpper() == n.ToUpper())
                {
                    iguales = true;
                    break;
                }
            }

            if(nuevoNombre == "")
            {
                MessageBox.Show("Ingrese un nombre");
                txtNombre.Clear();
            }else if(iguales)
            {
                MessageBox.Show("No se pueden repetir los nombres");
                txtNombre.Clear();
            }
            else
            {
                lbNombres1.Items.Add(nuevoNombre);
                txtNombre.Clear();
            }
        }

        //Al apretar > pasar el nombre a la segunda lista
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lbNombres1.SelectedItems.Count > 0)
            {
                lbNombres2.Items.Add(lbNombres1.SelectedItem.ToString());

                lbNombres1.Items.Remove(lbNombres1.SelectedItem);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun nombre");
            }
        }

        //Al apretar >> pasar todos los nombres a la segunda lista
        private void btnAll_Right_Click(object sender, EventArgs e)
        {
            if (lbNombres1.Items.Count > 0)
            {

                foreach (string n in lbNombres1.Items)
                {
                    lbNombres2.Items.Add(n);
                }
                lbNombres1.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nombres en la lista");
            }
        }

        //Al apretar < pasar el nombre a la primer lista
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lbNombres2.SelectedItems.Count > 0)
            {
                lbNombres1.Items.Add(lbNombres2.SelectedItem.ToString());

                lbNombres2.Items.Remove(lbNombres2.SelectedItem);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun nombre");
            }
        }
        //Al apretar << pasar todos los nombres a la segunda lista
        private void btnAll_Left_Click(object sender, EventArgs e)
        {
            if (lbNombres2.Items.Count > 0)
            {

                foreach (string n in lbNombres2.Items)
                {
                    lbNombres1.Items.Add(n);
                }
                lbNombres2.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nombres en la lista");
            }
        }

        //Hover boton Agregar
        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.Green;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.Green;
        }

        //Hover flecha >
        private void btnRight_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnRight.BackColor = Color.LightBlue;
        }

        private void btnRight_MouseLeave(object sender, EventArgs e)
        {
            btnRight.BackColor = Color.SkyBlue;
        }

        //Hover flecha >>
        private void btnAll_Right_MouseMove(object sender, MouseEventArgs e)
        {
            btnAll_Right.BackColor = Color.LightBlue;
        }

        private void btnAll_Right_MouseLeave(object sender, EventArgs e)
        {
            btnAll_Right.BackColor = Color.SkyBlue;
        }

        //hover flecha <
        private void btnLeft_MouseMove(object sender, MouseEventArgs e)
        {
            btnLeft.BackColor = Color.LightBlue;
        }
        private void btnLeft_MouseLeave(object sender, EventArgs e)
        {
            btnLeft.BackColor = Color.SkyBlue;
        }

        //hover flecha <<
        private void btnAll_Left_MouseMove(object sender, MouseEventArgs e)
        {
            btnAll_Left.BackColor = Color.LightBlue;
        }
        private void btnAll_Left_MouseLeave(object sender, EventArgs e)
        {
            btnAll_Left.BackColor = Color.SkyBlue;
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void lbNombres1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
