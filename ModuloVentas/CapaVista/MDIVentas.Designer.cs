﻿
namespace CapaVista
{
	partial class MDIVentas
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIVentas));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.morasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fraccionamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// catalogosToolStripMenuItem
			// 
			this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.morasToolStripMenuItem,
            this.fraccionamientosToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.documentosToolStripMenuItem});
			this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
			this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.catalogosToolStripMenuItem.Text = "Catalogos";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// morasToolStripMenuItem
			// 
			this.morasToolStripMenuItem.Name = "morasToolStripMenuItem";
			this.morasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.morasToolStripMenuItem.Text = "Moras";
			this.morasToolStripMenuItem.Click += new System.EventHandler(this.morasToolStripMenuItem_Click);
			// 
			// fraccionamientosToolStripMenuItem
			// 
			this.fraccionamientosToolStripMenuItem.Name = "fraccionamientosToolStripMenuItem";
			this.fraccionamientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fraccionamientosToolStripMenuItem.Text = "Fraccionamientos";
			this.fraccionamientosToolStripMenuItem.Click += new System.EventHandler(this.fraccionamientosToolStripMenuItem_Click);
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// inventariosToolStripMenuItem
			// 
			this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoInventarioToolStripMenuItem,
            this.inventarioToolStripMenuItem});
			this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
			this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.inventariosToolStripMenuItem.Text = "Inventarios";
			// 
			// tipoInventarioToolStripMenuItem
			// 
			this.tipoInventarioToolStripMenuItem.Name = "tipoInventarioToolStripMenuItem";
			this.tipoInventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.tipoInventarioToolStripMenuItem.Text = "Tipo Inventario";
			this.tipoInventarioToolStripMenuItem.Click += new System.EventHandler(this.tipoInventarioToolStripMenuItem_Click);
			// 
			// inventarioToolStripMenuItem
			// 
			this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
			this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.inventarioToolStripMenuItem.Text = "Inventario";
			this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
			// 
			// documentosToolStripMenuItem
			// 
			this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDocumentoToolStripMenuItem});
			this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
			this.documentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.documentosToolStripMenuItem.Text = "Documentos";
			// 
			// tipoDocumentoToolStripMenuItem
			// 
			this.tipoDocumentoToolStripMenuItem.Name = "tipoDocumentoToolStripMenuItem";
			this.tipoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.tipoDocumentoToolStripMenuItem.Text = "Tipo Documento";
			this.tipoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDocumentoToolStripMenuItem_Click);
			// 
			// MDIVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources.fondo_ventas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDIVentas";
			this.Text = "MDIVentas";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem morasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fraccionamientosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tipoInventarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tipoDocumentoToolStripMenuItem;
	}
}