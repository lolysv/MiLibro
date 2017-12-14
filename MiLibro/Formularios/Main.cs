using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLibro.Formularios
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void descuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Descuentos descuentos = new Descuentos();
            descuentos.FormBorderStyle = FormBorderStyle.None;
            descuentos.AutoScroll = true;
            descuentos.TopLevel = false;
            descuentos.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(descuentos);
            descuentos.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Empleados empleados = new Empleados();
            empleados.FormBorderStyle = FormBorderStyle.None;
            empleados.AutoScroll = true;
            empleados.TopLevel = false;
            empleados.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(empleados);
            empleados.Show();
        }

        private void otrosIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            OtrosIngresos otrosIngresos = new OtrosIngresos();
            otrosIngresos.FormBorderStyle = FormBorderStyle.None;
            otrosIngresos.AutoScroll = true;
            otrosIngresos.TopLevel = false;
            otrosIngresos.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(otrosIngresos);
            otrosIngresos.Show();
        }

        private void planillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Planillas planillas = new Planillas();
            planillas.FormBorderStyle = FormBorderStyle.None;
            planillas.AutoScroll = true;
            planillas.TopLevel = false;
            planillas.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(planillas);
            planillas.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Usuarios usuarios = new Usuarios();
            usuarios.FormBorderStyle = FormBorderStyle.None;
            usuarios.AutoScroll = true;
            usuarios.TopLevel = false;
            usuarios.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(usuarios);
            usuarios.Show();
        }
    }
}
