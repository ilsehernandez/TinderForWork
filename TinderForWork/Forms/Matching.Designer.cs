namespace TinderForWork.Forms
{
    partial class Matching
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matching));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VerComoUsuario = new System.Windows.Forms.Button();
            this.VerComoProyecto = new System.Windows.Forms.Button();
            this.AñadirProyecto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dislike = new System.Windows.Forms.Button();
            this.SuperLike = new System.Windows.Forms.Button();
            this.Like = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.viewPossibleProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinderForWorkDBDataSet = new TinderForWork.TinderForWorkDBDataSet();
            this.viewPossibleProjectsTableAdapter = new TinderForWork.TinderForWorkDBDataSetTableAdapters.ViewPossibleProjectsTableAdapter();
            this.lblHorasTrabajo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblNoMas = new System.Windows.Forms.Label();
            this.BotonMatches = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPossibleProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinderForWorkDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VerComoUsuario);
            this.panel1.Controls.Add(this.VerComoProyecto);
            this.panel1.Controls.Add(this.AñadirProyecto);
            this.panel1.Location = new System.Drawing.Point(1354, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 566);
            this.panel1.TabIndex = 1;
            // 
            // VerComoUsuario
            // 
            this.VerComoUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.VerComoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerComoUsuario.BackgroundImage")));
            this.VerComoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerComoUsuario.Location = new System.Drawing.Point(44, 173);
            this.VerComoUsuario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.VerComoUsuario.Name = "VerComoUsuario";
            this.VerComoUsuario.Size = new System.Drawing.Size(151, 136);
            this.VerComoUsuario.TabIndex = 0;
            this.VerComoUsuario.UseVisualStyleBackColor = false;
            this.VerComoUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerComoProyecto
            // 
            this.VerComoProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerComoProyecto.BackgroundImage")));
            this.VerComoProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerComoProyecto.Location = new System.Drawing.Point(44, 6);
            this.VerComoProyecto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.VerComoProyecto.Name = "VerComoProyecto";
            this.VerComoProyecto.Size = new System.Drawing.Size(151, 156);
            this.VerComoProyecto.TabIndex = 0;
            this.VerComoProyecto.UseVisualStyleBackColor = true;
            this.VerComoProyecto.Click += new System.EventHandler(this.button1_Click);
            // 
            // AñadirProyecto
            // 
            this.AñadirProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AñadirProyecto.BackgroundImage")));
            this.AñadirProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AñadirProyecto.Location = new System.Drawing.Point(44, 321);
            this.AñadirProyecto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AñadirProyecto.Name = "AñadirProyecto";
            this.AñadirProyecto.Size = new System.Drawing.Size(151, 143);
            this.AñadirProyecto.TabIndex = 0;
            this.AñadirProyecto.UseVisualStyleBackColor = true;
            this.AñadirProyecto.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dislike);
            this.groupBox1.Controls.Add(this.SuperLike);
            this.groupBox1.Controls.Add(this.Like);
            this.groupBox1.Location = new System.Drawing.Point(204, 650);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(1030, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Dislike
            // 
            this.Dislike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dislike.BackgroundImage")));
            this.Dislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dislike.Location = new System.Drawing.Point(12, 25);
            this.Dislike.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Dislike.Name = "Dislike";
            this.Dislike.Size = new System.Drawing.Size(168, 156);
            this.Dislike.TabIndex = 0;
            this.Dislike.UseVisualStyleBackColor = true;
            this.Dislike.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuperLike
            // 
            this.SuperLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SuperLike.BackgroundImage")));
            this.SuperLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SuperLike.Location = new System.Drawing.Point(442, 25);
            this.SuperLike.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SuperLike.Name = "SuperLike";
            this.SuperLike.Size = new System.Drawing.Size(168, 156);
            this.SuperLike.TabIndex = 0;
            this.SuperLike.UseVisualStyleBackColor = true;
            this.SuperLike.Click += new System.EventHandler(this.button1_Click);
            // 
            // Like
            // 
            this.Like.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Like.BackgroundImage")));
            this.Like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Like.Location = new System.Drawing.Point(850, 25);
            this.Like.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(168, 156);
            this.Like.TabIndex = 0;
            this.Like.UseVisualStyleBackColor = true;
            this.Like.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(664, 129);
            this.lblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(282, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label1dadfsdcsdcsdvsdcsdc";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(664, 165);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(282, 25);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "label1dadfsdcsdcsdvsdcsdc";
            // 
            // viewPossibleProjectsBindingSource
            // 
            this.viewPossibleProjectsBindingSource.DataMember = "ViewPossibleProjects";
            this.viewPossibleProjectsBindingSource.DataSource = this.tinderForWorkDBDataSet;
            // 
            // tinderForWorkDBDataSet
            // 
            this.tinderForWorkDBDataSet.DataSetName = "TinderForWorkDBDataSet";
            this.tinderForWorkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPossibleProjectsTableAdapter
            // 
            this.viewPossibleProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // lblHorasTrabajo
            // 
            this.lblHorasTrabajo.AutoSize = true;
            this.lblHorasTrabajo.Location = new System.Drawing.Point(664, 351);
            this.lblHorasTrabajo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHorasTrabajo.Name = "lblHorasTrabajo";
            this.lblHorasTrabajo.Size = new System.Drawing.Size(282, 25);
            this.lblHorasTrabajo.TabIndex = 3;
            this.lblHorasTrabajo.Text = "label1dadfsdcsdcsdvsdcsdc";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(664, 386);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(282, 25);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "label1dadfsdcsdcsdvsdcsdc";
            // 
            // lblNoMas
            // 
            this.lblNoMas.AutoSize = true;
            this.lblNoMas.Location = new System.Drawing.Point(669, 514);
            this.lblNoMas.Name = "lblNoMas";
            this.lblNoMas.Size = new System.Drawing.Size(0, 25);
            this.lblNoMas.TabIndex = 4;
            // 
            // BotonMatches
            // 
            this.BotonMatches.Location = new System.Drawing.Point(79, 282);
            this.BotonMatches.Name = "BotonMatches";
            this.BotonMatches.Size = new System.Drawing.Size(109, 101);
            this.BotonMatches.TabIndex = 5;
            this.BotonMatches.Text = "Tus Matches";
            this.BotonMatches.UseVisualStyleBackColor = true;
            this.BotonMatches.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.BotonMatches);
            this.Controls.Add(this.lblNoMas);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblHorasTrabajo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Matching";
            this.Text = "Matching";
            this.Load += new System.EventHandler(this.Matching_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewPossibleProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinderForWorkDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Like;
        private System.Windows.Forms.Button Dislike;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VerComoUsuario;
        private System.Windows.Forms.Button VerComoProyecto;
        private System.Windows.Forms.Button SuperLike;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button AñadirProyecto;
        private System.Windows.Forms.BindingSource viewPossibleProjectsBindingSource;
        private TinderForWorkDBDataSet tinderForWorkDBDataSet;
        private TinderForWorkDBDataSetTableAdapters.ViewPossibleProjectsTableAdapter viewPossibleProjectsTableAdapter;
        private System.Windows.Forms.Label lblHorasTrabajo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblNoMas;
        private System.Windows.Forms.Button BotonMatches;
    }
}