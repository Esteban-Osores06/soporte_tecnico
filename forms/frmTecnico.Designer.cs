using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace soporte_tecnico.forms
{
    partial class frmTecnico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private TextBox txtEmail;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvTecnicos;

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
        /// <summary>
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            txtEmail = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvTecnicos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((ISupportInitialize)dgvTecnicos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 39);
            txtNombre.TabIndex = 0;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(12, 117);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(194, 39);
            txtEspecialidad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 39);
            txtEmail.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(207, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(301, 338);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(398, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTecnicos
            // 
            dgvTecnicos.AllowUserToAddRows = false;
            dgvTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTecnicos.Location = new Point(223, 12);
            dgvTecnicos.MultiSelect = false;
            dgvTecnicos.Name = "dgvTecnicos";
            dgvTecnicos.ReadOnly = true;
            dgvTecnicos.RowHeadersWidth = 51;
            dgvTecnicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTecnicos.Size = new Size(443, 295);
            dgvTecnicos.TabIndex = 6;
            dgvTecnicos.SelectionChanged += dgvTecnicos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 8;
            label2.Text = "Especialidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            // 
            // frmTecnico
            // 
            ClientSize = new Size(812, 466);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTecnicos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Name = "frmTecnico";
            Load += frmTecnicos_Load;
            ((ISupportInitialize)dgvTecnicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
