
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ETCatPago = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETCatPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(113, 47);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 29);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvListaContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaContacto.AutoGenerateColumns = false;
            this.dgvListaContacto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaContacto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvListaContacto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaContacto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaContacto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaContacto.EnableHeadersVisualStyles = false;
            this.dgvListaContacto.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaContacto.Location = new System.Drawing.Point(7, 84);
            this.dgvListaContacto.MultiSelect = false;
            this.dgvListaContacto.Name = "dgvListaContacto";
            this.dgvListaContacto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaContacto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaContacto.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaContacto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaContacto.Size = new System.Drawing.Size(896, 423);
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
            this.idcontactoDataGridViewTextBoxColumn.Width = 75;
            // 
            // codigotcDataGridViewTextBoxColumn
            // 
            this.codigotcDataGridViewTextBoxColumn.DataPropertyName = "codigo_tc";
            this.codigotcDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.codigotcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigotcDataGridViewTextBoxColumn.Name = "codigotcDataGridViewTextBoxColumn";
            this.codigotcDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigotcDataGridViewTextBoxColumn.Width = 52;
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
            this.temailffeeDataGridViewTextBoxColumn.Width = 56;
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
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(6, 47);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 29);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.Text = "    Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ETCatPago
            // 
            this.ETCatPago.DataSource = typeof(Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGODTO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(41, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mantenimiento de contactos (Clientes, Proveeodres, Garantes, Contratantes)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "CONTACTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(879, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 26);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmListaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvListaContacto);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaContacto";
            this.Text = "frmCategoriaPago";
            this.Load += new System.EventHandler(this.frmListaContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETCatPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvListaContacto;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
    }
}