
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
            this.dgvListaContacto = new System.Windows.Forms.DataGridView();
            this.idcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigotcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trazonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temailffeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ETContacto = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ETCatPago = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ETCatPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Inactivo";
            this.dataGridViewImageColumn2.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Eliminar2;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
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
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Editar Registro";
            this.dataGridViewImageColumn1.Width = 33;
            // 
            // dgvListaContacto
            // 
            this.dgvListaContacto.AllowUserToAddRows = false;
            this.dgvListaContacto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvListaContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaContacto.AutoGenerateColumns = false;
            this.dgvListaContacto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaContacto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvListaContacto.ColumnHeadersHeight = 30;
            this.dgvListaContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontactoDataGridViewTextBoxColumn,
            this.codigotcDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.trazonsocialDataGridViewTextBoxColumn,
            this.tcontactoDataGridViewTextBoxColumn,
            this.temailffeeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Edit});
            this.dgvListaContacto.DataSource = this.ETContacto;
            this.dgvListaContacto.EnableHeadersVisualStyles = false;
            this.dgvListaContacto.Location = new System.Drawing.Point(6, 82);
            this.dgvListaContacto.MultiSelect = false;
            this.dgvListaContacto.Name = "dgvListaContacto";
            this.dgvListaContacto.ReadOnly = true;
            this.dgvListaContacto.RowHeadersWidth = 51;
            this.dgvListaContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaContacto.Size = new System.Drawing.Size(903, 442);
            this.dgvListaContacto.TabIndex = 34;
            this.dgvListaContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaContacto_CellContentClick);
            this.dgvListaContacto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaContacto_CellFormatting);
            // 
            // idcontactoDataGridViewTextBoxColumn
            // 
            this.idcontactoDataGridViewTextBoxColumn.DataPropertyName = "id_contacto";
            this.idcontactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.idcontactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcontactoDataGridViewTextBoxColumn.Name = "idcontactoDataGridViewTextBoxColumn";
            this.idcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcontactoDataGridViewTextBoxColumn.Visible = false;
            this.idcontactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigotcDataGridViewTextBoxColumn
            // 
            this.codigotcDataGridViewTextBoxColumn.DataPropertyName = "codigo_tc";
            this.codigotcDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.codigotcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigotcDataGridViewTextBoxColumn.Name = "codigotcDataGridViewTextBoxColumn";
            this.codigotcDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigotcDataGridViewTextBoxColumn.Width = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // trazonsocialDataGridViewTextBoxColumn
            // 
            this.trazonsocialDataGridViewTextBoxColumn.DataPropertyName = "t_razon_social";
            this.trazonsocialDataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.trazonsocialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trazonsocialDataGridViewTextBoxColumn.Name = "trazonsocialDataGridViewTextBoxColumn";
            this.trazonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.trazonsocialDataGridViewTextBoxColumn.Width = 95;
            // 
            // tcontactoDataGridViewTextBoxColumn
            // 
            this.tcontactoDataGridViewTextBoxColumn.DataPropertyName = "t_contacto";
            this.tcontactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.tcontactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcontactoDataGridViewTextBoxColumn.Name = "tcontactoDataGridViewTextBoxColumn";
            this.tcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcontactoDataGridViewTextBoxColumn.Width = 75;
            // 
            // temailffeeDataGridViewTextBoxColumn
            // 
            this.temailffeeDataGridViewTextBoxColumn.DataPropertyName = "t_email_ffee";
            this.temailffeeDataGridViewTextBoxColumn.HeaderText = "Email";
            this.temailffeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temailffeeDataGridViewTextBoxColumn.Name = "temailffeeDataGridViewTextBoxColumn";
            this.temailffeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.temailffeeDataGridViewTextBoxColumn.Width = 57;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Ver Detalle";
            this.Edit.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Editar2;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.ToolTipText = "Editar Registro";
            this.Edit.Width = 65;
            // 
            // ETContacto
            // 
            this.ETContacto.DataSource = typeof(Romsoft.GESTIONCLINICA.DTO.TABLAS.CON_CONTACTO.CON_CONTACTODTO);
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
            // ETCatPago
            // 
            this.ETCatPago.DataSource = typeof(Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGODTO);
            // 
            // frmListaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvListaContacto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaContacto";
            this.Text = "frmCategoriaPago";
            this.Load += new System.EventHandler(this.frmListaContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ETCatPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvListaContacto;
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