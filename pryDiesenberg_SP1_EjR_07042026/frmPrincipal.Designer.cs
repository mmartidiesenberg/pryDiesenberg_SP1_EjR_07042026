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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnGestionarEspecialidades = new System.Windows.Forms.Button();
            this.btnGestionarMedicos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitulo.Location = new System.Drawing.Point(156, 62);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(694, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Gestión de Clínica";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBienvenida.Location = new System.Drawing.Point(200, 173);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(594, 37);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido al sistema de gestión médica";
            // 
            // btnGestionarEspecialidades
            // 
            this.btnGestionarEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGestionarEspecialidades.Location = new System.Drawing.Point(200, 288);
            this.btnGestionarEspecialidades.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGestionarEspecialidades.Name = "btnGestionarEspecialidades";
            this.btnGestionarEspecialidades.Size = new System.Drawing.Size(600, 96);
            this.btnGestionarEspecialidades.TabIndex = 2;
            this.btnGestionarEspecialidades.Text = "Gestionar Especialidades";
            this.btnGestionarEspecialidades.UseVisualStyleBackColor = true;
            this.btnGestionarEspecialidades.Click += new System.EventHandler(this.btnGestionarEspecialidades_Click);
            // 
            // btnGestionarMedicos
            // 
            this.btnGestionarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGestionarMedicos.Location = new System.Drawing.Point(200, 423);
            this.btnGestionarMedicos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGestionarMedicos.Name = "btnGestionarMedicos";
            this.btnGestionarMedicos.Size = new System.Drawing.Size(600, 96);
            this.btnGestionarMedicos.TabIndex = 3;
            this.btnGestionarMedicos.Text = "Gestionar Médicos";
            this.btnGestionarMedicos.UseVisualStyleBackColor = true;
            this.btnGestionarMedicos.Click += new System.EventHandler(this.btnGestionarMedicos_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConsultar.Location = new System.Drawing.Point(200, 558);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(600, 96);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar Médicos por Especialidad";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalir.Location = new System.Drawing.Point(200, 692);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(600, 96);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1000, 923);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGestionarMedicos);
            this.Controls.Add(this.btnGestionarEspecialidades);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Clínica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
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