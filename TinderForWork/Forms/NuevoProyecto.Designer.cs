namespace TinderForWork.Forms
{
    partial class NuevoProyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxTitulo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxHorasTrabajo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBoxCampo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ChckEstadoProyecto = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas De Trabajo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Campo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Activo";
            // 
            // TextBoxTitulo
            // 
            this.TextBoxTitulo.Location = new System.Drawing.Point(11, 42);
            this.TextBoxTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxTitulo.Name = "TextBoxTitulo";
            this.TextBoxTitulo.Size = new System.Drawing.Size(180, 29);
            this.TextBoxTitulo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxTitulo);
            this.panel1.Location = new System.Drawing.Point(132, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 92);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextBoxHorasTrabajo);
            this.panel2.Location = new System.Drawing.Point(132, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 107);
            this.panel2.TabIndex = 4;
            // 
            // TextBoxHorasTrabajo
            // 
            this.TextBoxHorasTrabajo.Location = new System.Drawing.Point(11, 46);
            this.TextBoxHorasTrabajo.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxHorasTrabajo.Name = "TextBoxHorasTrabajo";
            this.TextBoxHorasTrabajo.Size = new System.Drawing.Size(180, 29);
            this.TextBoxHorasTrabajo.TabIndex = 2;
            this.TextBoxHorasTrabajo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TextBoxDescripcion);
            this.panel3.Location = new System.Drawing.Point(132, 261);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 281);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(11, 50);
            this.TextBoxDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxDescripcion.Multiline = true;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(1053, 209);
            this.TextBoxDescripcion.TabIndex = 2;
            this.TextBoxDescripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ChckEstadoProyecto);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(812, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 107);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.TextBoxCampo);
            this.panel5.Location = new System.Drawing.Point(812, 22);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 92);
            this.panel5.TabIndex = 4;
            // 
            // TextBoxCampo
            // 
            this.TextBoxCampo.Location = new System.Drawing.Point(11, 42);
            this.TextBoxCampo.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxCampo.Name = "TextBoxCampo";
            this.TextBoxCampo.Size = new System.Drawing.Size(180, 29);
            this.TextBoxCampo.TabIndex = 2;
            this.TextBoxCampo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 640);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(962, 640);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChckEstadoProyecto
            // 
            this.ChckEstadoProyecto.AutoSize = true;
            this.ChckEstadoProyecto.Location = new System.Drawing.Point(11, 49);
            this.ChckEstadoProyecto.Name = "ChckEstadoProyecto";
            this.ChckEstadoProyecto.Size = new System.Drawing.Size(22, 21);
            this.ChckEstadoProyecto.TabIndex = 2;
            this.ChckEstadoProyecto.UseVisualStyleBackColor = true;
            // 
            // NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NuevoProyecto";
            this.Text = "NuevoProyecto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextBoxHorasTrabajo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.TextBox TextBoxCampo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ChckEstadoProyecto;
    }
}