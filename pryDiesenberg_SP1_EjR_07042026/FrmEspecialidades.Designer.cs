namespace pryDiesenberg_SP1_EjR_07042026
{
    partial class FrmEspecialidades
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
            this.lblIdEspecialidad = new System.Windows.Forms.Label();
            this.lblNombreEspecialidad = new System.Windows.Forms.Label();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(92, 37);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(547, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Nueva Especialidad";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblIdEspecialidad
            // 
            this.lblIdEspecialidad.AutoSize = true;
            this.lblIdEspecialidad.Location = new System.Drawing.Point(60, 135);
            this.lblIdEspecialidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdEspecialidad.Name = "lblIdEspecialidad";
            this.lblIdEspecialidad.Size = new System.Drawing.Size(167, 25);
            this.lblIdEspecialidad.TabIndex = 1;
            this.lblIdEspecialidad.Text = "ID Especialidad:";
            // 
            // lblNombreEspecialidad
            // 
            this.lblNombreEspecialidad.AutoSize = true;
            this.lblNombreEspecialidad.Location = new System.Drawing.Point(60, 212);
            this.lblNombreEspecialidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreEspecialidad.Name = "lblNombreEspecialidad";
            this.lblNombreEspecialidad.Size = new System.Drawing.Size(222, 25);
            this.lblNombreEspecialidad.TabIndex = 3;
            this.lblNombreEspecialidad.Text = "Nombre Especialidad:";
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Location = new System.Drawing.Point(280, 129);
            this.txtIdEspecialidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(236, 31);
            this.txtIdEspecialidad.TabIndex = 2;
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(280, 206);
            this.txtNombreEspecialidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(356, 31);
            this.txtNombreEspecialidad.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 308);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(240, 58);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(400, 308);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(240, 58);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(700, 423);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreEspecialidad);
            this.Controls.Add(this.lblNombreEspecialidad);
            this.Controls.Add(this.txtIdEspecialidad);
            this.Controls.Add(this.lblIdEspecialidad);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Especialidad";
            this.Load += new System.EventHandler(this.FrmEspecialidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdEspecialidad;
        private System.Windows.Forms.Label lblNombreEspecialidad;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}