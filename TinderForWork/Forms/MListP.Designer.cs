namespace TinderForWork.Forms
{
    partial class MListP
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
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.ListaTelefono = new System.Windows.Forms.ListBox();
            this.ListaNombre = new System.Windows.Forms.ListBox();
            this.ListaCorreo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(951, 624);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(6);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(150, 44);
            this.BotonCerrar.TabIndex = 5;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            // 
            // ListaTelefono
            // 
            this.ListaTelefono.FormattingEnabled = true;
            this.ListaTelefono.ItemHeight = 25;
            this.ListaTelefono.Location = new System.Drawing.Point(909, 58);
            this.ListaTelefono.Margin = new System.Windows.Forms.Padding(6);
            this.ListaTelefono.Name = "ListaTelefono";
            this.ListaTelefono.Size = new System.Drawing.Size(254, 404);
            this.ListaTelefono.TabIndex = 2;
            // 
            // ListaNombre
            // 
            this.ListaNombre.FormattingEnabled = true;
            this.ListaNombre.ItemHeight = 25;
            this.ListaNombre.Location = new System.Drawing.Point(91, 58);
            this.ListaNombre.Margin = new System.Windows.Forms.Padding(6);
            this.ListaNombre.Name = "ListaNombre";
            this.ListaNombre.Size = new System.Drawing.Size(254, 404);
            this.ListaNombre.TabIndex = 3;
            // 
            // ListaCorreo
            // 
            this.ListaCorreo.FormattingEnabled = true;
            this.ListaCorreo.ItemHeight = 25;
            this.ListaCorreo.Location = new System.Drawing.Point(517, 58);
            this.ListaCorreo.Margin = new System.Windows.Forms.Padding(6);
            this.ListaCorreo.Name = "ListaCorreo";
            this.ListaCorreo.Size = new System.Drawing.Size(254, 404);
            this.ListaCorreo.TabIndex = 4;
            // 
            // MListP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 743);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.ListaTelefono);
            this.Controls.Add(this.ListaNombre);
            this.Controls.Add(this.ListaCorreo);
            this.Name = "MListP";
            this.Text = "MListP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.ListBox ListaTelefono;
        private System.Windows.Forms.ListBox ListaNombre;
        private System.Windows.Forms.ListBox ListaCorreo;
    }
}