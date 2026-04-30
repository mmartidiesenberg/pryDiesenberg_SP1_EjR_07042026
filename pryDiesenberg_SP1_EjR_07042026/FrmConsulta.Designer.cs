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
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(480, 383);
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
    }
}