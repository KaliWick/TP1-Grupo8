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
    }
}
