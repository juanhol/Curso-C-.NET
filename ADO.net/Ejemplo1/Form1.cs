using Example1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private List<Pokemon> Pokemonlist = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonService service=new PokemonService();
            Pokemonlist = service.tolist();
            dgbpokemons.DataSource = Pokemonlist;
            dgbpokemons.Columns["ImageUrl"].Visible = false;
            pcbPokemon.Load(Pokemonlist[0].ImageUrl);
        }

        private void dgbpokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selected=(Pokemon)dgbpokemons.CurrentRow.DataBoundItem;
            loadimg(selected.ImageUrl);
        }

        private void loadimg(string img)
        {
            try
            {
                pcbPokemon.Load(img);
            }
            catch (Exception)
            {

                pcbPokemon.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }
    }
}
