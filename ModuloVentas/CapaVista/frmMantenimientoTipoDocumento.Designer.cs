﻿
namespace CapaVista
{
	partial class frmMantenimientoTipoDocumento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoTipoDocumento));
			this.labelTipoDocumentos = new System.Windows.Forms.Label();
			this.dtgTipoDocumento = new System.Windows.Forms.DataGridView();
			this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
			this.rbnHabilitado = new System.Windows.Forms.RadioButton();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtidtdocumento = new System.Windows.Forms.TextBox();
			this.txtnombremora = new System.Windows.Forms.TextBox();
			this.labelestadotdocumento = new System.Windows.Forms.Label();
			this.labelnombretdocumento = new System.Windows.Forms.Label();
			this.labelidtdocumento = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumento)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTipoDocumentos
			// 
			this.labelTipoDocumentos.AutoSize = true;
			this.labelTipoDocumentos.BackColor = System.Drawing.Color.Transparent;
			this.labelTipoDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipoDocumentos.Location = new System.Drawing.Point(362, 44);
			this.labelTipoDocumentos.Name = "labelTipoDocumentos";
			this.labelTipoDocumentos.Size = new System.Drawing.Size(246, 20);
			this.labelTipoDocumentos.TabIndex = 30;
			this.labelTipoDocumentos.Text = "Tipos de Documento Registrados";
			// 
			// dtgTipoDocumento
			// 
			this.dtgTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgTipoDocumento.Location = new System.Drawing.Point(365, 65);
			this.dtgTipoDocumento.Name = "dtgTipoDocumento";
			this.dtgTipoDocumento.Size = new System.Drawing.Size(419, 215);
			this.dtgTipoDocumento.TabIndex = 29;
			// 
			// rbnInhabilitado
			// 
			this.rbnInhabilitado.AutoSize = true;
			this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
			this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnInhabilitado.Location = new System.Drawing.Point(199, 129);
			this.rbnInhabilitado.Name = "rbnInhabilitado";
			this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
			this.rbnInhabilitado.TabIndex = 28;
			this.rbnInhabilitado.TabStop = true;
			this.rbnInhabilitado.Text = "Inhabilitado";
			this.rbnInhabilitado.UseVisualStyleBackColor = false;
			// 
			// rbnHabilitado
			// 
			this.rbnHabilitado.AutoSize = true;
			this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
			this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnHabilitado.Location = new System.Drawing.Point(97, 131);
			this.rbnHabilitado.Name = "rbnHabilitado";
			this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
			this.rbnHabilitado.TabIndex = 27;
			this.rbnHabilitado.TabStop = true;
			this.rbnHabilitado.Text = "Habilitado";
			this.rbnHabilitado.UseVisualStyleBackColor = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(50, 229);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(92, 31);
			this.btnEliminar.TabIndex = 26;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(149, 229);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(92, 31);
			this.btnLimpiar.TabIndex = 25;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(149, 197);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(92, 31);
			this.btnModificar.TabIndex = 24;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(50, 197);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(92, 31);
			this.btnIngresar.TabIndex = 23;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			// 
			// txtidtdocumento
			// 
			this.txtidtdocumento.Location = new System.Drawing.Point(97, 44);
			this.txtidtdocumento.Name = "txtidtdocumento";
			this.txtidtdocumento.Size = new System.Drawing.Size(100, 20);
			this.txtidtdocumento.TabIndex = 22;
			// 
			// txtnombremora
			// 
			this.txtnombremora.Location = new System.Drawing.Point(97, 72);
			this.txtnombremora.Name = "txtnombremora";
			this.txtnombremora.Size = new System.Drawing.Size(100, 20);
			this.txtnombremora.TabIndex = 20;
			// 
			// labelestadotdocumento
			// 
			this.labelestadotdocumento.AutoSize = true;
			this.labelestadotdocumento.BackColor = System.Drawing.Color.Transparent;
			this.labelestadotdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelestadotdocumento.Location = new System.Drawing.Point(17, 129);
			this.labelestadotdocumento.Name = "labelestadotdocumento";
			this.labelestadotdocumento.Size = new System.Drawing.Size(64, 20);
			this.labelestadotdocumento.TabIndex = 19;
			this.labelestadotdocumento.Text = "Estado:";
			// 
			// labelnombretdocumento
			// 
			this.labelnombretdocumento.AutoSize = true;
			this.labelnombretdocumento.BackColor = System.Drawing.Color.Transparent;
			this.labelnombretdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelnombretdocumento.Location = new System.Drawing.Point(17, 77);
			this.labelnombretdocumento.Name = "labelnombretdocumento";
			this.labelnombretdocumento.Size = new System.Drawing.Size(69, 20);
			this.labelnombretdocumento.TabIndex = 17;
			this.labelnombretdocumento.Text = "Nombre:";
			// 
			// labelidtdocumento
			// 
			this.labelidtdocumento.AutoSize = true;
			this.labelidtdocumento.BackColor = System.Drawing.Color.Transparent;
			this.labelidtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelidtdocumento.Location = new System.Drawing.Point(17, 49);
			this.labelidtdocumento.Name = "labelidtdocumento";
			this.labelidtdocumento.Size = new System.Drawing.Size(30, 20);
			this.labelidtdocumento.TabIndex = 16;
			this.labelidtdocumento.Text = "ID:";
			// 
			// frmMantenimientoTipoDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 325);
			this.Controls.Add(this.labelTipoDocumentos);
			this.Controls.Add(this.dtgTipoDocumento);
			this.Controls.Add(this.rbnInhabilitado);
			this.Controls.Add(this.rbnHabilitado);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.txtidtdocumento);
			this.Controls.Add(this.txtnombremora);
			this.Controls.Add(this.labelestadotdocumento);
			this.Controls.Add(this.labelnombretdocumento);
			this.Controls.Add(this.labelidtdocumento);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMantenimientoTipoDocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenimiento Tipo de Documento";
			((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTipoDocumentos;
		private System.Windows.Forms.DataGridView dtgTipoDocumento;
		private System.Windows.Forms.RadioButton rbnInhabilitado;
		private System.Windows.Forms.RadioButton rbnHabilitado;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.TextBox txtidtdocumento;
		private System.Windows.Forms.TextBox txtnombremora;
		private System.Windows.Forms.Label labelestadotdocumento;
		private System.Windows.Forms.Label labelnombretdocumento;
		private System.Windows.Forms.Label labelidtdocumento;
	}
}