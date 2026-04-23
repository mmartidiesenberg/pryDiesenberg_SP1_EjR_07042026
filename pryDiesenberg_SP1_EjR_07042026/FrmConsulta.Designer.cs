namespace pryDiesenberg_SP1_EjR_07042026
{
    partial class FrmConsulta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarEspecialidad = new System.Windows.Forms.Button();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(61, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta de Médicos por Especialidad";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(50, 70);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(130, 67);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(300, 21);
            this.cmbEspecialidad.TabIndex = 2;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(50, 110);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(380, 250);
            this.dgvMedicos.TabIndex = 3;
            // 
            // btnRegistrarEspecialidad
            // 
            this.btnRegistrarEspecialidad.Location = new System.Drawing.Point(50, 380);
            this.btnRegistrarEspecialidad.Name = "btnRegistrarEspecialidad";
            this.btnRegistrarEspecialidad.Size = new System.Drawing.Size(180, 30);
            this.btnRegistrarEspecialidad.TabIndex = 4;
            this.btnRegistrarEspecialidad.Text = "Registrar Especialidad";
            this.btnRegistrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistrarEspecialidad.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Location = new System.Drawing.Point(250, 380);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(180, 30);
            this.btnRegistrarMedico.TabIndex = 5;
            this.btnRegistrarMedico.Text = "Registrar Médico";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 430);
            this.Controls.Add(this.btnRegistrarMedico);
            this.Controls.Add(this.btnRegistrarEspecialidad);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Médicos";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnRegistrarEspecialidad;
        private System.Windows.Forms.Button btnRegistrarMedico;
    }
}