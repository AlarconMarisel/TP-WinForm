namespace TP_WindForm
{
    partial class FrmAgregarImagen
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
            this.lblImagen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptarImagen = new System.Windows.Forms.Button();
            this.btnCancelarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(34, 40);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(58, 13);
            this.lblImagen.TabIndex = 0;
            this.lblImagen.Text = "Url Imagen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 296);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceptarImagen
            // 
            this.btnAceptarImagen.Location = new System.Drawing.Point(109, 419);
            this.btnAceptarImagen.Name = "btnAceptarImagen";
            this.btnAceptarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarImagen.TabIndex = 3;
            this.btnAceptarImagen.Text = "Aceptar";
            this.btnAceptarImagen.UseVisualStyleBackColor = true;
            // 
            // btnCancelarImagen
            // 
            this.btnCancelarImagen.Location = new System.Drawing.Point(283, 419);
            this.btnCancelarImagen.Name = "btnCancelarImagen";
            this.btnCancelarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarImagen.TabIndex = 4;
            this.btnCancelarImagen.Text = "Cancelar";
            this.btnCancelarImagen.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 466);
            this.Controls.Add(this.btnCancelarImagen);
            this.Controls.Add(this.btnAceptarImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblImagen);
            this.Name = "FrmAgregarImagen";
            this.Text = "Agregar Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptarImagen;
        private System.Windows.Forms.Button btnCancelarImagen;
    }
}