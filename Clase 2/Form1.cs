using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColor.Items.Add("Rojo");
            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Verde");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string name=txtNombre.Text+" "+txtApellido.Text;
            DateTime fechanacimiento = dtpFechaNacimiento.Value;
            //operador ternario
            string gay = ckbGay.Checked == true ? "Es gay" : "No es gay";
            string tipo;
            if(rbtGnome.Checked == true)
            { tipo = "Gnomo"; }
            else if (rbtMuggle.Checked == true)
            { tipo = "Muggle"; }
            else { tipo = "Wizard"; }
            string colorFavorito=cmbColor.SelectedItem.ToString();
            string numeroFavorito=nudNumeroFavorito.Value.ToString();
            string mensaje = "Nombre: " + name + "\nFecha de nacimiento: " + fechanacimiento + " \n" + gay + "\nEs " + tipo + "\nSu color favorito es " + colorFavorito +
                "\nSu numero favorito es " + numeroFavorito + ".";
            MessageBox.Show(mensaje);
        }
    }
}
