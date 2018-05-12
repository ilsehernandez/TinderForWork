namespace TinderForWork.Forms
{
    partial class Match_List
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
            this.ListaCorreo = new System.Windows.Forms.ListBox();
            this.ListaTelefono = new System.Windows.Forms.ListBox();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.ListaNombre = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaCorreo
            // 
            this.ListaCorreo.FormattingEnabled = true;
            this.ListaCorreo.ItemHeight = 25;
            this.ListaCorreo.Location = new System.Drawing.Point(516, 121);
            this.ListaCorreo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListaCorreo.Name = "ListaCorreo";
            this.ListaCorreo.Size = new System.Drawing.Size(254, 404);
            this.ListaCorreo.TabIndex = 0;
            // 
            // ListaTelefono
            // 
            this.ListaTelefono.FormattingEnabled = true;
            this.ListaTelefono.ItemHeight = 25;
            this.ListaTelefono.Location = new System.Drawing.Point(908, 121);
            this.ListaTelefono.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListaTelefono.Name = "ListaTelefono";
            this.ListaTelefono.Size = new System.Drawing.Size(254, 404);
            this.ListaTelefono.TabIndex = 0;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(950, 687);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(150, 44);
            this.BotonCerrar.TabIndex = 1;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // ListaNombre
            // 
            this.ListaNombre.FormattingEnabled = true;
            this.ListaNombre.ItemHeight = 25;
            this.ListaNombre.Location = new System.Drawing.Point(90, 121);
            this.ListaNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListaNombre.Name = "ListaNombre";
            this.ListaNombre.Size = new System.Drawing.Size(254, 404);
            this.ListaNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tus Matches";
            // 
            // Match_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.ListaTelefono);
            this.Controls.Add(this.ListaNombre);
            this.Controls.Add(this.ListaCorreo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Match_List";
            this.Text = "Match_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaCorreo;
        private System.Windows.Forms.ListBox ListaTelefono;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.ListBox ListaNombre;
        private System.Windows.Forms.Label label1;
    }
}