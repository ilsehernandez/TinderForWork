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
            this.panel1 = new System.Windows.Forms.Panel();
            this.VerComoUsuario = new System.Windows.Forms.Button();
            this.VerComoProyecto = new System.Windows.Forms.Button();
            this.AñadirProyecto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dislike = new System.Windows.Forms.Button();
            this.SuperLike = new System.Windows.Forms.Button();
            this.Like = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horasServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewPossibleProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinderForWorkDBDataSet = new TinderForWork.TinderForWorkDBDataSet();
            this.viewPossibleProjectsTableAdapter = new TinderForWork.TinderForWorkDBDataSetTableAdapters.ViewPossibleProjectsTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.VerComoUsuario.BackgroundImage = global::TinderForWork.Properties.Resources.coolest_roller_coaster_clipart_11_individual_people_icon_images_single_user_icon_clip_roller_coaster_clipart;
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
            this.VerComoProyecto.BackgroundImage = global::TinderForWork.Properties.Resources.group_clipart_clip_art_group_300x300;
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
            this.AñadirProyecto.BackgroundImage = global::TinderForWork.Properties.Resources.plus_sign_hi__1_;
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
            this.Dislike.BackgroundImage = global::TinderForWork.Properties.Resources.thumbsdown;
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
            this.SuperLike.BackgroundImage = global::TinderForWork.Properties.Resources.black_heart_hi;
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
            this.Like.BackgroundImage = global::TinderForWork.Properties.Resources.thumbs;
            this.Like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Like.Location = new System.Drawing.Point(850, 25);
            this.Like.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(168, 156);
            this.Like.TabIndex = 0;
            this.Like.UseVisualStyleBackColor = true;
            this.Like.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1dadfsdcsdcsdvsdcsdc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label1dadfsdcsdcsdvsdcsdc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proyectoIDDataGridViewTextBoxColumn,
            this.horasTrabajoDataGridViewTextBoxColumn,
            this.nombreProyectoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.campoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.horasServicioDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewPossibleProjectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(249, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 156);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proyectoIDDataGridViewTextBoxColumn
            // 
            this.proyectoIDDataGridViewTextBoxColumn.DataPropertyName = "ProyectoID";
            this.proyectoIDDataGridViewTextBoxColumn.HeaderText = "ProyectoID";
            this.proyectoIDDataGridViewTextBoxColumn.Name = "proyectoIDDataGridViewTextBoxColumn";
            // 
            // horasTrabajoDataGridViewTextBoxColumn
            // 
            this.horasTrabajoDataGridViewTextBoxColumn.DataPropertyName = "HorasTrabajo";
            this.horasTrabajoDataGridViewTextBoxColumn.HeaderText = "HorasTrabajo";
            this.horasTrabajoDataGridViewTextBoxColumn.Name = "horasTrabajoDataGridViewTextBoxColumn";
            // 
            // nombreProyectoDataGridViewTextBoxColumn
            // 
            this.nombreProyectoDataGridViewTextBoxColumn.DataPropertyName = "NombreProyecto";
            this.nombreProyectoDataGridViewTextBoxColumn.HeaderText = "NombreProyecto";
            this.nombreProyectoDataGridViewTextBoxColumn.Name = "nombreProyectoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // campoDataGridViewTextBoxColumn
            // 
            this.campoDataGridViewTextBoxColumn.DataPropertyName = "Campo";
            this.campoDataGridViewTextBoxColumn.HeaderText = "Campo";
            this.campoDataGridViewTextBoxColumn.Name = "campoDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // horasServicioDataGridViewTextBoxColumn
            // 
            this.horasServicioDataGridViewTextBoxColumn.DataPropertyName = "HorasServicio";
            this.horasServicioDataGridViewTextBoxColumn.HeaderText = "HorasServicio";
            this.horasServicioDataGridViewTextBoxColumn.Name = "horasServicioDataGridViewTextBoxColumn";
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
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
            // Matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Matching";
            this.Text = "Matching";
            this.Load += new System.EventHandler(this.Matching_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AñadirProyecto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewPossibleProjectsBindingSource;
        private TinderForWorkDBDataSet tinderForWorkDBDataSet;
        private TinderForWorkDBDataSetTableAdapters.ViewPossibleProjectsTableAdapter viewPossibleProjectsTableAdapter;
    }
}