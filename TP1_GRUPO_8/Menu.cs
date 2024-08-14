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
    public partial class TP1_GRUPO_8 : Form
    {
        public TP1_GRUPO_8()
        {
            InitializeComponent();
        }

        private void BtnEjercicio1_Click(object sender, EventArgs e) //EVENTO CLICK PARA ABRIR EL FORM DEL EJ 1
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void BtnEjercicio2_Click(object sender, EventArgs e) //EVENTO CLICK PARA ABRIR EL FORM DEL EJ 2
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void BtnEjercicio3_Click(object sender, EventArgs e) //EVENTO CLICK PARA ABRIR EL FORM DEL EJ 3
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void TP1_GRUPO_8_Load(object sender, EventArgs e)
        {

        }
        //hover boton ej1
        private void BtnEjercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            BtnEjercicio1.BackColor = Color.LightBlue;
        }

        private void BtnEjercicio1_MouseLeave(object sender, EventArgs e)
        {
            BtnEjercicio1.BackColor = SystemColors.InactiveBorder;
        }

        //hover boton ej2
        private void BtnEjercicio2_MouseMove(object sender, MouseEventArgs e)
        {
            BtnEjercicio2.BackColor = Color.LightBlue;
        }

        private void BtnEjercicio2_MouseLeave(object sender, EventArgs e)
        {
            BtnEjercicio2.BackColor = SystemColors.InactiveBorder;
        }
        //hover boton ej3
        private void BtnEjercicio3_MouseMove(object sender, MouseEventArgs e)
        {
            BtnEjercicio3.BackColor = Color.LightBlue;
        }

        private void BtnEjercicio3_MouseLeave(object sender, EventArgs e)
        {
            BtnEjercicio3.BackColor = SystemColors.InactiveBorder;
        }
    }
}
