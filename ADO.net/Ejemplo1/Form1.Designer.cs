namespace Ejemplo1
{
    partial class Form1
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
            this.dgbpokemons = new System.Windows.Forms.DataGridView();
            this.pcbPokemon = new System.Windows.Forms.PictureBox();
            this.btnAddPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbpokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbpokemons
            // 
            this.dgbpokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbpokemons.Location = new System.Drawing.Point(55, 53);
            this.dgbpokemons.Name = "dgbpokemons";
            this.dgbpokemons.RowHeadersWidth = 51;
            this.dgbpokemons.RowTemplate.Height = 24;
            this.dgbpokemons.Size = new System.Drawing.Size(459, 328);
            this.dgbpokemons.TabIndex = 0;
            this.dgbpokemons.SelectionChanged += new System.EventHandler(this.dgbpokemons_SelectionChanged);
            // 
            // pcbPokemon
            // 
            this.pcbPokemon.Location = new System.Drawing.Point(539, 76);
            this.pcbPokemon.Name = "pcbPokemon";
            this.pcbPokemon.Size = new System.Drawing.Size(322, 274);
            this.pcbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPokemon.TabIndex = 1;
            this.pcbPokemon.TabStop = false;
            // 
            // btnAddPokemon
            // 
            this.btnAddPokemon.Location = new System.Drawing.Point(53, 488);
            this.btnAddPokemon.Name = "btnAddPokemon";
            this.btnAddPokemon.Size = new System.Drawing.Size(109, 23);
            this.btnAddPokemon.TabIndex = 2;
            this.btnAddPokemon.Text = "Add Pokemon";
            this.btnAddPokemon.UseVisualStyleBackColor = true;
            this.btnAddPokemon.Click += new System.EventHandler(this.btnAddPokemon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 575);
            this.Controls.Add(this.btnAddPokemon);
            this.Controls.Add(this.pcbPokemon);
            this.Controls.Add(this.dgbpokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbpokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbpokemons;
        private System.Windows.Forms.PictureBox pcbPokemon;
        private System.Windows.Forms.Button btnAddPokemon;
    }
}

