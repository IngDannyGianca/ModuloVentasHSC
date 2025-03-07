﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
	public partial class MDIVentas : Form
	{
		public MDIVentas()
		{
			InitializeComponent();
			CenterToScreen();
			this.WindowState = FormWindowState.Maximized;
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMantenimientoCliente form3 = new frmMantenimientoCliente();
			form3.MdiParent = this;

			form3.Show();
		}

		private void morasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMantenimientoMora form3 = new frmMantenimientoMora();
			form3.MdiParent = this;

			form3.Show();
		}

		private void fraccionamientosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMantenimientoFraccionamiento form3 = new frmMantenimientoFraccionamiento();
			form3.MdiParent = this;

			form3.Show();
		}

		private void tipoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMantenimientoTipoInventario form3 = new frmMantenimientoTipoInventario();
			form3.MdiParent = this;

			form3.Show();
		}

		private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMantenimientoInventario form3 = new frmMantenimientoInventario();
			form3.MdiParent = this;

			form3.Show();
		}

		private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMantenimientoTipoDocumento form3 = new frmMantenimientoTipoDocumento();
			form3.MdiParent = this;

			form3.Show();
		}
	}
}
