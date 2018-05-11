namespace TinderForWork
{
    partial class Form1
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
            this.TextBoxMatriculaLog = new System.Windows.Forms.TextBox();
            this.TextBoxContraLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxMatriculaLog
            // 
            this.TextBoxMatriculaLog.Location = new System.Drawing.Point(53, 59);
            this.TextBoxMatriculaLog.Name = "TextBoxMatriculaLog";
            this.TextBoxMatriculaLog.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMatriculaLog.TabIndex = 0;
            // 
            // TextBoxContraLog
            // 
            this.TextBoxContraLog.Location = new System.Drawing.Point(53, 118);
            this.TextBoxContraLog.Name = "TextBoxContraLog";
            this.TextBoxContraLog.Size = new System.Drawing.Size(100, 20);
            this.TextBoxContraLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // NuevoUsuario
            // 
            this.NuevoUsuario.AutoSize = true;
            this.NuevoUsuario.Location = new System.Drawing.Point(63, 156);
            this.NuevoUsuario.Name = "NuevoUsuario";
            this.NuevoUsuario.Size = new System.Drawing.Size(78, 13);
            this.NuevoUsuario.TabIndex = 2;
            this.NuevoUsuario.TabStop = true;
            this.NuevoUsuario.Text = "Nuevo Usuario";
            this.NuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NuevoUsuario);
            this.panel1.Controls.Add(this.TextBoxMatriculaLog);
            this.panel1.Controls.Add(this.TextBoxContraLog);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 201);
            this.panel1.TabIndex = 3;
            // 
            // BotonLogin
            // 
            this.BotonLogin.Location = new System.Drawing.Point(106, 247);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Size = new System.Drawing.Size(75, 23);
            this.BotonLogin.TabIndex = 4;
            this.BotonLogin.Text = "Login";
            this.BotonLogin.UseVisualStyleBackColor = true;
            this.BotonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 302);
            this.Controls.Add(this.BotonLogin);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxMatriculaLog;
        private System.Windows.Forms.TextBox TextBoxContraLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel NuevoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonLogin;
    }
}

