using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace soporte_tecnico.forms
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            // marcar por defecto el botón 'Todos' como seleccionado visualmente
            SetEstadoSeleccionado(btnTodos);
        }

        private void SetEstadoSeleccionado(Button seleccionado)
        {
            // lista de botones de estado
            var estados = new[] { btnPendientes, btnEnProceso, btnResueltos, btnTodos };
            foreach (var b in estados)
            {
                if (b == seleccionado)
                {
                    b.BackColor = Color.LightBlue; // seleccionado
                }
                else
                {
                    b.BackColor = Color.LightCyan; // no seleccionado
                }
            }
        }

        private void btnPendientes_Click(object sender, EventArgs e) => SetEstadoSeleccionado(btnPendientes);
        private void btnEnProceso_Click(object sender, EventArgs e) => SetEstadoSeleccionado(btnEnProceso);
        private void btnResueltos_Click(object sender, EventArgs e) => SetEstadoSeleccionado(btnResueltos);
        private void btnTodos_Click(object sender, EventArgs e) => SetEstadoSeleccionado(btnTodos);

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }
    }
}
