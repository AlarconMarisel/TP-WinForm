namespace TP_WindForm
{
    partial class FrmListaCategoria
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
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.BtnAgregarCategoria = new System.Windows.Forms.Button();
            this.BtnModificarCategoria = new System.Windows.Forms.Button();
            this.BtnEliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.Location = new System.Drawing.Point(72, 144);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.RowHeadersWidth = 82;
            this.DgvCategorias.RowTemplate.Height = 33;
            this.DgvCategorias.Size = new System.Drawing.Size(618, 510);
            this.DgvCategorias.TabIndex = 0;
            this.DgvCategorias.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategorias_CellMouseEnter);
            this.DgvCategorias.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategorias_CellMouseLeave);
            this.DgvCategorias.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCategorias_ColumnHeaderMouseClick);
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(73, 699);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(172, 72);
            this.BtnAgregarCategoria.TabIndex = 1;
            this.BtnAgregarCategoria.Text = "Agregar";
            this.BtnAgregarCategoria.UseVisualStyleBackColor = true;
            this.BtnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // BtnModificarCategoria
            // 
            this.BtnModificarCategoria.Location = new System.Drawing.Point(291, 699);
            this.BtnModificarCategoria.Name = "BtnModificarCategoria";
            this.BtnModificarCategoria.Size = new System.Drawing.Size(170, 72);
            this.BtnModificarCategoria.TabIndex = 2;
            this.BtnModificarCategoria.Text = "Modificar";
            this.BtnModificarCategoria.UseVisualStyleBackColor = true;
            this.BtnModificarCategoria.Click += new System.EventHandler(this.BtnModificarCategoria_Click);
            // 
            // BtnEliminarCategoria
            // 
            this.BtnEliminarCategoria.Location = new System.Drawing.Point(521, 699);
            this.BtnEliminarCategoria.Name = "BtnEliminarCategoria";
            this.BtnEliminarCategoria.Size = new System.Drawing.Size(170, 72);
            this.BtnEliminarCategoria.TabIndex = 3;
            this.BtnEliminarCategoria.Text = "Eliminar";
            this.BtnEliminarCategoria.UseVisualStyleBackColor = true;
            this.BtnEliminarCategoria.Click += new System.EventHandler(this.BtnEliminarCategoria_Click);
            // 
            // FrmListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 831);
            this.Controls.Add(this.BtnEliminarCategoria);
            this.Controls.Add(this.BtnModificarCategoria);
            this.Controls.Add(this.BtnAgregarCategoria);
            this.Controls.Add(this.DgvCategorias);
            this.Name = "FrmListaCategoria";
            this.Text = "FrmListaCategoria";
            this.Load += new System.EventHandler(this.FrmListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.Button BtnAgregarCategoria;
        private System.Windows.Forms.Button BtnModificarCategoria;
        private System.Windows.Forms.Button BtnEliminarCategoria;
    }
}