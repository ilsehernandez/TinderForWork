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
            this.ListaCorreo.Location = new System.Drawing.Point(258, 63);
            this.ListaCorreo.Name = "ListaCorreo";
            this.ListaCorreo.Size = new System.Drawing.Size(129, 212);
            this.ListaCorreo.TabIndex = 0;
            // 
            // ListaTelefono
            // 
            this.ListaTelefono.FormattingEnabled = true;
            this.ListaTelefono.Location = new System.Drawing.Point(454, 63);
            this.ListaTelefono.Name = "ListaTelefono";
            this.ListaTelefono.Size = new System.Drawing.Size(129, 212);
            this.ListaTelefono.TabIndex = 0;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(475, 357);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(75, 23);
            this.BotonCerrar.TabIndex = 1;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            // 
            // ListaNombre
            // 
            this.ListaNombre.FormattingEnabled = true;
            this.ListaNombre.Location = new System.Drawing.Point(45, 63);
            this.ListaNombre.Name = "ListaNombre";
            this.ListaNombre.Size = new System.Drawing.Size(129, 212);
            this.ListaNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tus Matches";
            // 
            // Match_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.ListaTelefono);
            this.Controls.Add(this.ListaNombre);
            this.Controls.Add(this.ListaCorreo);
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