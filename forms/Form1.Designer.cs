namespace soporte_tecnico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnClientes;
        private Button btnTecnicos;
        private Button btnSeguimiento;
        private Button btnReportes;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnTecnicos = new Button();
            btnSeguimiento = new Button();
            btnReportes = new Button();
            label1 = new Label();
            SuspendLayout();

            // btnClientes
            btnClientes.Location = new Point(50, 100);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(140, 50);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;

            // btnTecnicos
            btnTecnicos.Location = new Point(50, 170);
            btnTecnicos.Name = "btnTecnicos";
            btnTecnicos.Size = new Size(140, 50);
            btnTecnicos.TabIndex = 1;
            btnTecnicos.Text = "Técnicos";
            btnTecnicos.UseVisualStyleBackColor = true;
            btnTecnicos.Click += btnTecnicos_Click;

            // btnSeguimiento
            btnSeguimiento.Location = new Point(50, 240);
            btnSeguimiento.Name = "btnSeguimiento";
            btnSeguimiento.Size = new Size(140, 50);
            btnSeguimiento.TabIndex = 2;
            btnSeguimiento.Text = "Seguimiento";
            btnSeguimiento.UseVisualStyleBackColor = true;
            btnSeguimiento.Click += btnSeguimiento_Click;

            // btnReportes
            btnReportes.Location = new Point(50, 310);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(140, 50);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 4;
            label1.Text = "SOPORTE TÉCNICO";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReportes);
            Controls.Add(btnSeguimiento);
            Controls.Add(btnTecnicos);
            Controls.Add(btnClientes);
            Name = "Form1";
            Text = "Sistema de Soporte Técnico";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}