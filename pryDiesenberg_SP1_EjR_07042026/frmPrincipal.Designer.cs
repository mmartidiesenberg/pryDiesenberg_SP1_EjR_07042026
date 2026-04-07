namespace pryDiesenberg_SP1_EjR_07042026
{
    partial class frmPrincipal
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnGestionarEspecialidades = new System.Windows.Forms.Button();
            this.btnGestionarMedicos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(100, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Gestión de Clínica";

            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBienvenida.Location = new System.Drawing.Point(100, 90);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(300, 20);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido al sistema de gestión médica";

            this.btnGestionarEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGestionarEspecialidades.Location = new System.Drawing.Point(100, 150);
            this.btnGestionarEspecialidades.Name = "btnGestionarEspecialidades";
            this.btnGestionarEspecialidades.Size = new System.Drawing.Size(300, 50);
            this.btnGestionarEspecialidades.TabIndex = 2;
            this.btnGestionarEspecialidades.Text = "Gestionar Especialidades";
            this.btnGestionarEspecialidades.UseVisualStyleBackColor = true;
            this.btnGestionarEspecialidades.Click += new System.EventHandler(this.btnGestionarEspecialidades_Click);

            this.btnGestionarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGestionarMedicos.Location = new System.Drawing.Point(100, 220);
            this.btnGestionarMedicos.Name = "btnGestionarMedicos";
            this.btnGestionarMedicos.Size = new System.Drawing.Size(300, 50);
            this.btnGestionarMedicos.TabIndex = 3;
            this.btnGestionarMedicos.Text = "Gestionar Médicos";
            this.btnGestionarMedicos.UseVisualStyleBackColor = true;
            this.btnGestionarMedicos.Click += new System.EventHandler(this.btnGestionarMedicos_Click);

            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConsultar.Location = new System.Drawing.Point(100, 290);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(300, 50);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar Médicos por Especialidad";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalir.Location = new System.Drawing.Point(100, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(300, 50);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGestionarMedicos);
            this.Controls.Add(this.btnGestionarEspecialidades);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestión de Clínica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnGestionarEspecialidades;
        private System.Windows.Forms.Button btnGestionarMedicos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
    }
}