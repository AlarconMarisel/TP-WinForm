namespace TP_WindForm
{
    partial class FrmArticuloListado
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnVerDetalleArticulo = new System.Windows.Forms.Button();
            this.lblFiltroArticulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(40, 125);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1112, 481);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(40, 662);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(232, 54);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(332, 662);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(232, 54);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(628, 662);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(232, 54);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnVerDetalleArticulo
            // 
            this.btnVerDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleArticulo.Location = new System.Drawing.Point(920, 662);
            this.btnVerDetalleArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerDetalleArticulo.Name = "btnVerDetalleArticulo";
            this.btnVerDetalleArticulo.Size = new System.Drawing.Size(232, 54);
            this.btnVerDetalleArticulo.TabIndex = 5;
            this.btnVerDetalleArticulo.Text = "Ver Detalle";
            this.btnVerDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // lblFiltroArticulo
            // 
            this.lblFiltroArticulo.AutoSize = true;
            this.lblFiltroArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroArticulo.Location = new System.Drawing.Point(35, 51);
            this.lblFiltroArticulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltroArticulo.Name = "lblFiltroArticulo";
            this.lblFiltroArticulo.Size = new System.Drawing.Size(71, 30);
            this.lblFiltroArticulo.TabIndex = 6;
            this.lblFiltroArticulo.Text = "Filtro";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 37);
            this.textBox1.TabIndex = 7;
            // 
            // FrmArticuloListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 821);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFiltroArticulo);
            this.Controls.Add(this.btnVerDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1226, 892);
            this.Name = "FrmArticuloListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticuloListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnVerDetalleArticulo;
        private System.Windows.Forms.Label lblFiltroArticulo;
        private System.Windows.Forms.TextBox textBox1;
    }
}