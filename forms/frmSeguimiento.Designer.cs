namespace soporte_tecnico.forms
{
    partial class frmSeguimiento
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
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            button1 = new Button();
            dgvSeguimiento = new DataGridView();
            cmbEstado = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtComentario = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(-1, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(177, 32);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar pedido: ";
            lblBuscar.Click += label1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(171, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 39);
            txtBuscar.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(388, 12);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvSeguimiento
            // 
            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguimiento.Location = new Point(36, 110);
            dgvSeguimiento.Name = "dgvSeguimiento";
            dgvSeguimiento.RowHeadersWidth = 82;
            dgvSeguimiento.Size = new Size(1461, 540);
            dgvSeguimiento.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(81, 717);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(242, 40);
            cmbEstado.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 665);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 5;
            label1.Text = "Estado: ";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 802);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 6;
            label2.Text = "Comentario: ";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(81, 849);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(200, 78);
            txtComentario.TabIndex = 7;
            txtComentario.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(662, 1075);
            button2.Name = "button2";
            button2.Size = new Size(353, 46);
            button2.TabIndex = 8;
            button2.Text = "Guardar Cambios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmSeguimiento
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 1256);
            Controls.Add(button2);
            Controls.Add(txtComentario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEstado);
            Controls.Add(dgvSeguimiento);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Name = "frmSeguimiento";
            Text = "frmSeguimiento";
            Load += frmSeguimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button button1;
        private DataGridView dgvSeguimiento;
        private ComboBox cmbEstado;
        private Label label1;
        private Label label2;
        private TextBox txtComentario;
        private Button button2;
    }
}