namespace TP_WindForm
{
    partial class FrmListaMarca
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
            this.DgvListaDeMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDeMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaDeMarcas
            // 
            this.DgvListaDeMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListaDeMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaDeMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvListaDeMarcas.Location = new System.Drawing.Point(37, 86);
            this.DgvListaDeMarcas.MultiSelect = false;
            this.DgvListaDeMarcas.Name = "DgvListaDeMarcas";
            this.DgvListaDeMarcas.RowHeadersWidth = 51;
            this.DgvListaDeMarcas.RowTemplate.Height = 24;
            this.DgvListaDeMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaDeMarcas.Size = new System.Drawing.Size(435, 184);
            this.DgvListaDeMarcas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 288);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(177, 288);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(109, 40);
            this.btnModificarMarca.TabIndex = 2;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.button2_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(319, 288);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(109, 40);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(170, 26);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(302, 22);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(34, 26);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(84, 16);
            this.lblFiltroMarca.TabIndex = 5;
            this.lblFiltroMarca.Text = "Filtro Rapido";
            // 
            // FrmListaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 372);
            this.Controls.Add(this.lblFiltroMarca);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvListaDeMarcas);
            this.Name = "FrmListaMarca";
            this.Text = "Lista de Marca";
            this.Load += new System.EventHandler(this.FrmListaMarca_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDeMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaDeMarcas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltroMarca;
    }
}