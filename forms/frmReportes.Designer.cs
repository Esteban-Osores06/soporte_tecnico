namespace soporte_tecnico.forms
{
    partial class frmReportes
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
            btnPendientes = new Button();
            btnEnProceso = new Button();
            btnResueltos = new Button();
            btnTodos = new Button();
            dgvSeguimiento = new DataGridView();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).BeginInit();
            SuspendLayout();
            // 
            // btnPendientes
            // 
            btnPendientes.Location = new Point(44, 35);
            btnPendientes.Name = "btnPendientes";
            btnPendientes.Size = new Size(150, 46);
            btnPendientes.TabIndex = 0;
            btnPendientes.Text = "Pendientes";
            btnPendientes.UseVisualStyleBackColor = true;
            // 
            // btnEnProceso
            // 
            btnEnProceso.Location = new Point(241, 35);
            btnEnProceso.Name = "btnEnProceso";
            btnEnProceso.Size = new Size(150, 46);
            btnEnProceso.TabIndex = 1;
            btnEnProceso.Text = "En Proceso";
            btnEnProceso.UseVisualStyleBackColor = true;
            // 
            // btnResueltos
            // 
            btnResueltos.Location = new Point(439, 35);
            btnResueltos.Name = "btnResueltos";
            btnResueltos.Size = new Size(150, 46);
            btnResueltos.TabIndex = 2;
            btnResueltos.Text = "Resueltos";
            btnResueltos.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(633, 35);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(150, 46);
            btnTodos.TabIndex = 3;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            // 
            // dgvSeguimiento
            // 
            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguimiento.Location = new Point(65, 167);
            dgvSeguimiento.Name = "dgvSeguimiento";
            dgvSeguimiento.RowHeadersWidth = 82;
            dgvSeguimiento.Size = new Size(1346, 576);
            dgvSeguimiento.TabIndex = 4;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(675, 914);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(150, 46);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 1230);
            Controls.Add(btnExportar);
            Controls.Add(dgvSeguimiento);
            Controls.Add(btnTodos);
            Controls.Add(btnResueltos);
            Controls.Add(btnEnProceso);
            Controls.Add(btnPendientes);
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPendientes;
        private Button btnEnProceso;
        private Button btnResueltos;
        private Button btnTodos;
        private DataGridView dgvSeguimiento;
        private Button btnExportar;
    }
}