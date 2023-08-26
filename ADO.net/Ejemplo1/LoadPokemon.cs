using domain;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class LoadPokemon : Form
    {
        public LoadPokemon()
        {
            InitializeComponent();
        }

     

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pokemon Poke = new Pokemon();
            PokemonService service = new PokemonService();
            try
            {
                
                Poke.Name = txbName.Text;
                Poke.Description = txbDescription.Text;
                Poke.Number=int.Parse(txbNumber.Text);
                Poke.Type = (Element)cmbElement.SelectedItem;
                Poke.Weakness = (Element)cmbWeakness.SelectedItem;

                service.AddPokemon(Poke);
                MessageBox.Show("The pokemon has been added correctly");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadPokemon_Load(object sender, EventArgs e)
        {
            ElementService elementService = new ElementService();
            try
            {
                cmbElement.DataSource = elementService.tolist();
                cmbWeakness.DataSource = elementService.tolist();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
