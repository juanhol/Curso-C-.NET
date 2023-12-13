using Domain;
using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Articleform : Form
    {
        private List<Article> articlesList;
        public Articleform()
        {
            InitializeComponent();
        }



        private void Articleform_Load(object sender, EventArgs e)
        {
            toLoad();
            cbxField.Items.Add("Price");
            cbxField.Items.Add("Name");
            cbxField.Items.Add("Description");
        }

        private void toLoad()
        {
            try
            {
                ArticleBusiness business = new ArticleBusiness();
                articlesList = business.toList();
                dgvArticles.DataSource = articlesList;
                ocultColumns();
                if (articlesList.Count > 0)
                {
                    LoadImg(articlesList[0].imgUrl);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticles.CurrentRow != null)
            {
                Article selected = (Article)dgvArticles.CurrentRow.DataBoundItem;
                LoadImg(selected.imgUrl);
            }
        }

        private void LoadImg(string img)
        {
            try
            {
                pcbArticle.Load(img);
            }
            catch (Exception ex)
            {

                pcbArticle.Load("https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image-300x203.jpg");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddArticle add = new FrmAddArticle();
            add.ShowDialog();
            toLoad();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Article selected = new Article();
            selected = (Article)dgvArticles.CurrentRow.DataBoundItem;
            FrmAddArticle modify = new FrmAddArticle(selected);
            modify.ShowDialog();
            toLoad();
        }

        private void btnDeletePhisically_Click(object sender, EventArgs e)
        {
            ArticleBusiness business = new ArticleBusiness();
            Article selected = new Article();
            try
            {
                DialogResult result = MessageBox.Show("Are you shure you want to delete this article?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    selected = (Article)dgvArticles.CurrentRow.DataBoundItem;
                    business.DeleteArticlePhisically(selected.Id);
                    toLoad();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ArticleBusiness business = new ArticleBusiness();
            try
            {
                string field = cbxField.Text;
                string criteria = cbxCriteria.Text;
                string key = txbKey.Text;
                dgvArticles.DataSource = business.advancedFilter(field, criteria, key);

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ocultColumns()
        {
            dgvArticles.Columns["imgUrl"].Visible = false;
            dgvArticles.Columns["Id"].Visible = false;
        }


        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txbFilter.Text;
            List<Article> filteredList;
            if (filter.Length >= 3)
            {
                filteredList = articlesList.FindAll(x => x.name.ToUpper().Contains(filter.ToUpper()));
            }
            else
            {
                filteredList = articlesList;
            }

            dgvArticles.DataSource = null;
            dgvArticles.DataSource = filteredList;
            ocultColumns();
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cbxField.SelectedItem.ToString();
            try
            {
                if (option == "Price")
                {
                    cbxCriteria.Items.Clear();
                    cbxCriteria.Items.Add("Higher than");
                    cbxCriteria.Items.Add("Equal to");
                    cbxCriteria.Items.Add("Lower than");
                }
                else
                {
                    cbxCriteria.Items.Clear();
                    cbxCriteria.Items.Add("Begins with");
                    cbxCriteria.Items.Add("Contains");
                    cbxCriteria.Items.Add("Ends in");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
