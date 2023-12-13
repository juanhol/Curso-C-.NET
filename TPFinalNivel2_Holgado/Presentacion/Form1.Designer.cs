namespace Presentacion
{
    partial class Articleform
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.pcbArticle = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDeletePhisically = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.lblField = new System.Windows.Forms.Label();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.cbxCriteria = new System.Windows.Forms.ComboBox();
            this.cbxField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticles
            // 
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Location = new System.Drawing.Point(12, 78);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(663, 251);
            this.dgvArticles.TabIndex = 0;
            this.dgvArticles.SelectionChanged += new System.EventHandler(this.dgvArticles_SelectionChanged);
            // 
            // pcbArticle
            // 
            this.pcbArticle.Location = new System.Drawing.Point(708, 31);
            this.pcbArticle.Name = "pcbArticle";
            this.pcbArticle.Size = new System.Drawing.Size(378, 298);
            this.pcbArticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbArticle.TabIndex = 1;
            this.pcbArticle.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(135, 351);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDeletePhisically
            // 
            this.btnDeletePhisically.Location = new System.Drawing.Point(234, 351);
            this.btnDeletePhisically.Name = "btnDeletePhisically";
            this.btnDeletePhisically.Size = new System.Drawing.Size(103, 23);
            this.btnDeletePhisically.TabIndex = 4;
            this.btnDeletePhisically.Text = "Delete";
            this.btnDeletePhisically.UseVisualStyleBackColor = true;
            this.btnDeletePhisically.Click += new System.EventHandler(this.btnDeletePhisically_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(559, 432);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(28, 55);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(66, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Quick Filter :";
            // 
            // txbFilter
            // 
            this.txbFilter.Location = new System.Drawing.Point(111, 52);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(419, 20);
            this.txbFilter.TabIndex = 7;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(47, 438);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(35, 13);
            this.lblField.TabIndex = 8;
            this.lblField.Text = "Field :";
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(213, 438);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(45, 13);
            this.lblCriteria.TabIndex = 10;
            this.lblCriteria.Text = "Criteria: ";
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(431, 434);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(122, 20);
            this.txbKey.TabIndex = 13;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(389, 438);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(31, 13);
            this.lblKey.TabIndex = 12;
            this.lblKey.Text = "Key :";
            // 
            // cbxCriteria
            // 
            this.cbxCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriteria.FormattingEnabled = true;
            this.cbxCriteria.Location = new System.Drawing.Point(265, 434);
            this.cbxCriteria.Name = "cbxCriteria";
            this.cbxCriteria.Size = new System.Drawing.Size(117, 21);
            this.cbxCriteria.TabIndex = 15;
            // 
            // cbxField
            // 
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Location = new System.Drawing.Point(89, 434);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(117, 21);
            this.cbxField.TabIndex = 14;
            this.cbxField.SelectedIndexChanged += new System.EventHandler(this.cbxField_SelectedIndexChanged);
            // 
            // Articleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 469);
            this.Controls.Add(this.cbxCriteria);
            this.Controls.Add(this.cbxField);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnDeletePhisically);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pcbArticle);
            this.Controls.Add(this.dgvArticles);
            this.Name = "Articleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation";
            this.Load += new System.EventHandler(this.Articleform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.PictureBox pcbArticle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDeletePhisically;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cbxCriteria;
        private System.Windows.Forms.ComboBox cbxField;
    }
}

