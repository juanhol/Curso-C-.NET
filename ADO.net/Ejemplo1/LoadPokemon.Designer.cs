namespace Example1
{
    partial class LoadPokemon
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblWeakness = new System.Windows.Forms.Label();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.cmbWeakness = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(31, 37);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 16);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(116, 37);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(96, 22);
            this.txbNumber.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(116, 79);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(96, 22);
            this.txbName.TabIndex = 1;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(116, 117);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(96, 22);
            this.txbDescription.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(34, 165);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(62, 16);
            this.lblElement.TabIndex = 8;
            this.lblElement.Text = "Element: ";
            // 
            // lblWeakness
            // 
            this.lblWeakness.AutoSize = true;
            this.lblWeakness.Location = new System.Drawing.Point(33, 225);
            this.lblWeakness.Name = "lblWeakness";
            this.lblWeakness.Size = new System.Drawing.Size(78, 16);
            this.lblWeakness.TabIndex = 9;
            this.lblWeakness.Text = "Weakness: ";
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(116, 162);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(121, 24);
            this.cmbElement.TabIndex = 3;
            // 
            // cmbWeakness
            // 
            this.cmbWeakness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeakness.FormattingEnabled = true;
            this.cmbWeakness.Location = new System.Drawing.Point(116, 222);
            this.cmbWeakness.Name = "cmbWeakness";
            this.cmbWeakness.Size = new System.Drawing.Size(121, 24);
            this.cmbWeakness.TabIndex = 4;
            // 
            // LoadPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 428);
            this.Controls.Add(this.cmbWeakness);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.lblWeakness);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Name = "LoadPokemon";
            this.Text = "LoadPokemon";
            this.Load += new System.EventHandler(this.LoadPokemon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblWeakness;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.ComboBox cmbWeakness;
    }
}