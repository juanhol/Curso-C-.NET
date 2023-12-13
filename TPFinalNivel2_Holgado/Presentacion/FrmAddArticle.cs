using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Business;
using System.Data.SqlTypes;

namespace Presentacion
{
    public partial class FrmAddArticle : Form
    {
        private Article article=null;
        public FrmAddArticle()
        {
            InitializeComponent();
        }
        public FrmAddArticle(Article article)
        {
            InitializeComponent();
            this.article = article;
            Text = "Modify Article";
        }

        private void FrmAddArticle_Load(object sender, EventArgs e)
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            List<Brand> brands = articleBusiness.getBrands();
            List<Category> categories = articleBusiness.getCategories();
            try
            {
                
                cbxBrand.DataSource = brands;
                cbxBrand.ValueMember ="brandId";
                cbxBrand.DisplayMember = "description";
                cbxCategory.DataSource = categories;
                cbxCategory.ValueMember = "categoryId";
                cbxCategory.DisplayMember = "description";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }
            if (article != null)
            {
                txbArticleCode.Text = article.articleCode;
                txbDescription.Text = article.description;
                txbImgUrl.Text = article.imgUrl;
                loadImg(txbImgUrl.Text);
                txbName.Text = article.name;
                txbPrice.Text=article.price.ToString();
                cbxBrand.SelectedValue = article.brand.brandId;
                cbxCategory.SelectedValue = article.category.categoryId;

            }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
           
            ArticleBusiness business = new ArticleBusiness();
            try
            {
                if (article == null)
                    article = new Article();
                article.articleCode=txbArticleCode.Text;
                article.price=decimal.Parse(txbPrice.Text);
                article.name=txbName.Text;
                article.description = txbDescription.Text;
                article.brand=(Brand)cbxBrand.SelectedItem;
                article.imgUrl=txbImgUrl.Text;
                article.category =(Category)cbxCategory.SelectedItem;

                if(article.Id != 0)
                {
                    business.modifyArticle(article);
                    MessageBox.Show("Successfully modified.");
                }
                else
                {
                    business.AddArticle(article);
                    MessageBox.Show("Successfully added.");
                }
                    Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
       
        private void txbImgUrl_Leave(object sender, EventArgs e)
        {
                loadImg(txbImgUrl.Text);
        }
        private void loadImg(string img)
        {
            try
            {
                pcbImg.Load(img);
            }
            catch (Exception ex)
            {

                pcbImg.Load("https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image-300x203.jpg");
            }
        }
    }
}
