﻿
namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloConvenios.Contacto
{
    partial class frmListaContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaContacto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvListaCatPago = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ETContacto = new System.Windows.Forms.BindingSource(this.components);
            this.ETCatPago = new System.Windows.Forms.BindingSource(this.components);
            this.idcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigotcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trazonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temailffeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCatPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ETContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETCatPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Inactivo";
            this.dataGridViewImageColumn2.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Eliminar2;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.ToolTipText = "Inactivo";
            this.dataGridViewImageColumn2.Width = 53;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(108, 51);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(104, 25);
            this.btnFiltrar.TabIndex = 37;
            this.btnFiltrar.Text = "   Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Editar2;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Editar Registro";
            this.dataGridViewImageColumn1.Width = 33;
            // 
            // dgvListaCatPago
            // 
            this.dgvListaCatPago.AllowUserToAddRows = false;
            this.dgvListaCatPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvListaCatPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCatPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCatPago.AutoGenerateColumns = false;
            this.dgvListaCatPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvListaCatPago.ColumnHeadersHeight = 30;
            this.dgvListaCatPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontactoDataGridViewTextBoxColumn,
            this.codigotcDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.trazonsocialDataGridViewTextBoxColumn,
            this.tcontactoDataGridViewTextBoxColumn,
            this.temailffeeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Edit});
            this.dgvListaCatPago.DataSource = this.ETContacto;
            this.dgvListaCatPago.EnableHeadersVisualStyles = false;
            this.dgvListaCatPago.Location = new System.Drawing.Point(6, 82);
            this.dgvListaCatPago.MultiSelect = false;
            this.dgvListaCatPago.Name = "dgvListaCatPago";
            this.dgvListaCatPago.ReadOnly = true;
            this.dgvListaCatPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCatPago.Size = new System.Drawing.Size(903, 442);
            this.dgvListaCatPago.TabIndex = 34;
            this.dgvListaCatPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCatPago_CellContentClick);
            this.dgvListaCatPago.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaCatPago_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mantenimiento de Contacto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(880, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 26);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 38);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mantenimiento de Garantes, Contratantes, Otros.";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(6, 51);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 25);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.Text = "    Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ETContacto
            // 
            this.ETContacto.DataSource = typeof(Romsoft.GESTIONCLINICA.DTO.TABLAS.CON_CONTACTO.CON_CONTACTODTO);
            // 
            // ETCatPago
            // 
            this.ETCatPago.DataSource = typeof(Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGODTO);
            // 
            // idcontactoDataGridViewTextBoxColumn
            // 
            this.idcontactoDataGridViewTextBoxColumn.DataPropertyName = "id_contacto";
            this.idcontactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.idcontactoDataGridViewTextBoxColumn.Name = "idcontactoDataGridViewTextBoxColumn";
            this.idcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcontactoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigotcDataGridViewTextBoxColumn
            // 
            this.codigotcDataGridViewTextBoxColumn.DataPropertyName = "codigo_tc";
            this.codigotcDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.codigotcDataGridViewTextBoxColumn.Name = "codigotcDataGridViewTextBoxColumn";
            this.codigotcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // trazonsocialDataGridViewTextBoxColumn
            // 
            this.trazonsocialDataGridViewTextBoxColumn.DataPropertyName = "t_razon_social";
            this.trazonsocialDataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.trazonsocialDataGridViewTextBoxColumn.Name = "trazonsocialDataGridViewTextBoxColumn";
            this.trazonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tcontactoDataGridViewTextBoxColumn
            // 
            this.tcontactoDataGridViewTextBoxColumn.DataPropertyName = "t_contacto";
            this.tcontactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.tcontactoDataGridViewTextBoxColumn.Name = "tcontactoDataGridViewTextBoxColumn";
            this.tcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temailffeeDataGridViewTextBoxColumn
            // 
            this.temailffeeDataGridViewTextBoxColumn.DataPropertyName = "t_email_ffee";
            this.temailffeeDataGridViewTextBoxColumn.HeaderText = "Email";
            this.temailffeeDataGridViewTextBoxColumn.Name = "temailffeeDataGridViewTextBoxColumn";
            this.temailffeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Ver Detalle";
            this.Edit.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Editar2;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.ToolTipText = "Editar Registro";
            this.Edit.Width = 65;
            // 
            // frmListaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvListaCatPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaContacto";
            this.Text = "frmCategoriaPago";
            this.Load += new System.EventHandler(this.frmListaContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCatPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ETContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETCatPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvListaCatPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ETCatPago;
        private System.Windows.Forms.BindingSource ETContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigotcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trazonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temailffeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}