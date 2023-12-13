namespace Presentacion
{
    partial class FrmAddArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArticleCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txbArticleCode = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbImgUrl = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblImgUrl = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.pcbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticleCode
            // 
            this.lblArticleCode.AutoSize = true;
            this.lblArticleCode.Location = new System.Drawing.Point(86, 44);
            this.lblArticleCode.Name = "lblArticleCode";
            this.lblArticleCode.Size = new System.Drawing.Size(64, 13);
            this.lblArticleCode.TabIndex = 0;
            this.lblArticleCode.Text = "Article Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(86, 171);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand";
            // 
            // txbArticleCode
            // 
            this.txbArticleCode.Location = new System.Drawing.Point(165, 41);
            this.txbArticleCode.Name = "txbArticleCode";
            this.txbArticleCode.Size = new System.Drawing.Size(100, 20);
            this.txbArticleCode.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(165, 107);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(93, 513);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbImgUrl
            // 
            this.txbImgUrl.Location = new System.Drawing.Point(165, 346);
            this.txbImgUrl.Name = "txbImgUrl";
            this.txbImgUrl.Size = new System.Drawing.Size(100, 20);
            this.txbImgUrl.TabIndex = 5;
            this.txbImgUrl.Leave += new System.EventHandler(this.txbImgUrl_Leave);
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(165, 285);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(100, 20);
            this.txbPrice.TabIndex = 4;
            // 
            // lblImgUrl
            // 
            this.lblImgUrl.AutoSize = true;
            this.lblImgUrl.Location = new System.Drawing.Point(86, 349);
            this.lblImgUrl.Name = "lblImgUrl";
            this.lblImgUrl.Size = new System.Drawing.Size(36, 13);
            this.lblImgUrl.TabIndex = 10;
            this.lblImgUrl.Text = "Image";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(86, 288);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(86, 222);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(86, 399);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(165, 396);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(100, 20);
            this.txbDescription.TabIndex = 6;
            // 
            // cbxBrand
            // 
            this.cbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(165, 168);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbxBrand.TabIndex = 2;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(165, 214);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxCategory.TabIndex = 3;
            // 
            // pcbImg
            // 
            this.pcbImg.Location = new System.Drawing.Point(359, 62);
            this.pcbImg.Name = "pcbImg";
            this.pcbImg.Size = new System.Drawing.Size(324, 353);
            this.pcbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImg.TabIndex = 18;
            this.pcbImg.TabStop = false;
            // 
            // FrmAddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 596);
            this.Controls.Add(this.pcbImg);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbImgUrl);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblImgUrl);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbArticleCode);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblArticleCode);
            this.Name = "FrmAddArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Article";
            this.Load += new System.EventHandler(this.FrmAddArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticleCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txbArticleCode;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbImgUrl;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblImgUrl;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.PictureBox pcbImg;
    }
}