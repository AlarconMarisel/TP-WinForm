namespace TP_WindForm
{
    partial class FrmPrincipal
    {   /// <summary>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedasDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(913, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeArticulosToolStripMenuItem,
            this.busquedaArticuloToolStripMenuItem,
            this.agregarArticuloToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // listadoDeArticulosToolStripMenuItem
            // 
            this.listadoDeArticulosToolStripMenuItem.Name = "listadoDeArticulosToolStripMenuItem";
            this.listadoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.listadoDeArticulosToolStripMenuItem.Text = "Listado de Articulos";
            this.listadoDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosToolStripMenuItem_Click);
            // 
            // busquedaArticuloToolStripMenuItem
            // 
            this.busquedaArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porMarcaToolStripMenuItem,
            this.porCategoriaToolStripMenuItem});
            this.busquedaArticuloToolStripMenuItem.Name = "busquedaArticuloToolStripMenuItem";
            this.busquedaArticuloToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.busquedaArticuloToolStripMenuItem.Text = "Busqueda Articulo";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            // 
            // porMarcaToolStripMenuItem
            // 
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.porMarcaToolStripMenuItem.Text = "Por Marca";
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.porCategoriaToolStripMenuItem.Text = "Por Categoria";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.modificarToolStripMenuItem.Text = "Modificar Articulo";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar Articulos";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.verToolStripMenuItem.Text = "Ver Detalle de un Articulo";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeMarcasToolStripMenuItem,
            this.busquedasDeMarcasToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.modificarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // listadoDeMarcasToolStripMenuItem
            // 
            this.listadoDeMarcasToolStripMenuItem.Name = "listadoDeMarcasToolStripMenuItem";
            this.listadoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.listadoDeMarcasToolStripMenuItem.Text = "Listado de Marcas ";
            this.listadoDeMarcasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeMarcasToolStripMenuItem_Click);
            // 
            // busquedasDeMarcasToolStripMenuItem
            // 
            this.busquedasDeMarcasToolStripMenuItem.Name = "busquedasDeMarcasToolStripMenuItem";
            this.busquedasDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.busquedasDeMarcasToolStripMenuItem.Text = "Busquedas de Marcas";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.agregarToolStripMenuItem.Text = "Agregar Marca";
            // 
            // modificarMarcaToolStripMenuItem
            // 
            this.modificarMarcaToolStripMenuItem.Name = "modificarMarcaToolStripMenuItem";
            this.modificarMarcaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.modificarMarcaToolStripMenuItem.Text = "Modificar Marca";
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCategoríasToolStripMenuItem,
            this.busquedaDeCategoríaToolStripMenuItem,
            this.agregarCategoríaToolStripMenuItem,
            this.modificarCategoríaToolStripMenuItem,
            this.eliminarCategoríaToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // listadoDeCategoríasToolStripMenuItem
            // 
            this.listadoDeCategoríasToolStripMenuItem.Name = "listadoDeCategoríasToolStripMenuItem";
            this.listadoDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.listadoDeCategoríasToolStripMenuItem.Text = "Listado de Categorías";
            // 
            // busquedaDeCategoríaToolStripMenuItem
            // 
            this.busquedaDeCategoríaToolStripMenuItem.Name = "busquedaDeCategoríaToolStripMenuItem";
            this.busquedaDeCategoríaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.busquedaDeCategoríaToolStripMenuItem.Text = "Busqueda de Categoría";
            // 
            // agregarCategoríaToolStripMenuItem
            // 
            this.agregarCategoríaToolStripMenuItem.Name = "agregarCategoríaToolStripMenuItem";
            this.agregarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.agregarCategoríaToolStripMenuItem.Text = "Agregar Categoría";
            // 
            // modificarCategoríaToolStripMenuItem
            // 
            this.modificarCategoríaToolStripMenuItem.Name = "modificarCategoríaToolStripMenuItem";
            this.modificarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.modificarCategoríaToolStripMenuItem.Text = "Modificar Categoría";
            // 
            // eliminarCategoríaToolStripMenuItem
            // 
            this.eliminarCategoríaToolStripMenuItem.Name = "eliminarCategoríaToolStripMenuItem";
            this.eliminarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.eliminarCategoríaToolStripMenuItem.Text = "Eliminar Categoría";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(293, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre app";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedasDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
    }
}

