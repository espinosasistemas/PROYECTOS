namespace SCI.INTERFAZ.UI
{
    partial class FormOtros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.btnCrearTipoGasto = new System.Windows.Forms.Button();
            this.btnBuscarTodosGastos = new System.Windows.Forms.Button();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.btnEditarEstado = new System.Windows.Forms.Button();
            this.btnAgregarEstado = new System.Windows.Forms.Button();
            this.btnMostrarEstados = new System.Windows.Forms.Button();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 26);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para el catálogo de Tipo de Gastos y Status de los Viajes.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(691, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEliminarGasto);
            this.groupBox1.Controls.Add(this.btnEditarGasto);
            this.groupBox1.Controls.Add(this.btnCrearTipoGasto);
            this.groupBox1.Controls.Add(this.btnBuscarTodosGastos);
            this.groupBox1.Controls.Add(this.dgvGastos);
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Todos los tipos de Gastos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarGasto.FlatAppearance.BorderSize = 0;
            this.btnEliminarGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEliminarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGasto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGasto.Image")));
            this.btnEliminarGasto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarGasto.Location = new System.Drawing.Point(414, 20);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarGasto.TabIndex = 5;
            this.btnEliminarGasto.Text = "Eliminar Gasto";
            this.btnEliminarGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarGasto.UseVisualStyleBackColor = false;
            // 
            // btnEditarGasto
            // 
            this.btnEditarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarGasto.FlatAppearance.BorderSize = 0;
            this.btnEditarGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEditarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGasto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGasto.Image")));
            this.btnEditarGasto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarGasto.Location = new System.Drawing.Point(278, 20);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(130, 33);
            this.btnEditarGasto.TabIndex = 4;
            this.btnEditarGasto.Text = "Editar Gasto";
            this.btnEditarGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarGasto.UseVisualStyleBackColor = false;
            this.btnEditarGasto.Click += new System.EventHandler(this.btnEditarGasto_Click);
            // 
            // btnCrearTipoGasto
            // 
            this.btnCrearTipoGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearTipoGasto.FlatAppearance.BorderSize = 0;
            this.btnCrearTipoGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCrearTipoGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTipoGasto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearTipoGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearTipoGasto.Image")));
            this.btnCrearTipoGasto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearTipoGasto.Location = new System.Drawing.Point(142, 20);
            this.btnCrearTipoGasto.Name = "btnCrearTipoGasto";
            this.btnCrearTipoGasto.Size = new System.Drawing.Size(130, 33);
            this.btnCrearTipoGasto.TabIndex = 2;
            this.btnCrearTipoGasto.Text = "Agregar Gasto";
            this.btnCrearTipoGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearTipoGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearTipoGasto.UseVisualStyleBackColor = false;
            this.btnCrearTipoGasto.Click += new System.EventHandler(this.btnCrearTipoGasto_Click);
            // 
            // btnBuscarTodosGastos
            // 
            this.btnBuscarTodosGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnBuscarTodosGastos.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodosGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnBuscarTodosGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodosGastos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarTodosGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodosGastos.Image")));
            this.btnBuscarTodosGastos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarTodosGastos.Location = new System.Drawing.Point(6, 20);
            this.btnBuscarTodosGastos.Name = "btnBuscarTodosGastos";
            this.btnBuscarTodosGastos.Size = new System.Drawing.Size(130, 33);
            this.btnBuscarTodosGastos.TabIndex = 1;
            this.btnBuscarTodosGastos.Text = "Mostrar Todos";
            this.btnBuscarTodosGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodosGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodosGastos.UseVisualStyleBackColor = false;
            this.btnBuscarTodosGastos.Click += new System.EventHandler(this.btnBuscarTodosGastos_Click);
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(6, 59);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.Size = new System.Drawing.Size(685, 159);
            this.dgvGastos.TabIndex = 0;
            this.dgvGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellClick);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panelResultado.Controls.Add(this.labelResultado);
            this.panelResultado.Controls.Add(this.label2);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelResultado.Location = new System.Drawing.Point(0, 502);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(718, 20);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(166, 2);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(62, 16);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado de la operación: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnEliminarEstado);
            this.groupBox2.Controls.Add(this.btnEditarEstado);
            this.groupBox2.Controls.Add(this.btnAgregarEstado);
            this.groupBox2.Controls.Add(this.btnMostrarEstados);
            this.groupBox2.Controls.Add(this.dgvStatus);
            this.groupBox2.Location = new System.Drawing.Point(9, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar Todos los status de los viajes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(621, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarEstado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEliminarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEstado.Image")));
            this.btnEliminarEstado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarEstado.Location = new System.Drawing.Point(414, 20);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarEstado.TabIndex = 5;
            this.btnEliminarEstado.Text = "Eliminar Estado";
            this.btnEliminarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEstado.UseVisualStyleBackColor = false;
            // 
            // btnEditarEstado
            // 
            this.btnEditarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarEstado.FlatAppearance.BorderSize = 0;
            this.btnEditarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEditarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEstado.Image")));
            this.btnEditarEstado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarEstado.Location = new System.Drawing.Point(278, 20);
            this.btnEditarEstado.Name = "btnEditarEstado";
            this.btnEditarEstado.Size = new System.Drawing.Size(130, 33);
            this.btnEditarEstado.TabIndex = 4;
            this.btnEditarEstado.Text = "Editar Estado";
            this.btnEditarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEstado.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEstado
            // 
            this.btnAgregarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnAgregarEstado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAgregarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEstado.Image")));
            this.btnAgregarEstado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarEstado.Location = new System.Drawing.Point(142, 20);
            this.btnAgregarEstado.Name = "btnAgregarEstado";
            this.btnAgregarEstado.Size = new System.Drawing.Size(130, 33);
            this.btnAgregarEstado.TabIndex = 2;
            this.btnAgregarEstado.Text = "Agregar Estado";
            this.btnAgregarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarEstado.UseVisualStyleBackColor = false;
            // 
            // btnMostrarEstados
            // 
            this.btnMostrarEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnMostrarEstados.FlatAppearance.BorderSize = 0;
            this.btnMostrarEstados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnMostrarEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEstados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMostrarEstados.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarEstados.Image")));
            this.btnMostrarEstados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMostrarEstados.Location = new System.Drawing.Point(6, 20);
            this.btnMostrarEstados.Name = "btnMostrarEstados";
            this.btnMostrarEstados.Size = new System.Drawing.Size(130, 33);
            this.btnMostrarEstados.TabIndex = 1;
            this.btnMostrarEstados.Text = "Mostrar Todos";
            this.btnMostrarEstados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarEstados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarEstados.UseVisualStyleBackColor = false;
            this.btnMostrarEstados.Click += new System.EventHandler(this.btnMostrarEstados_Click);
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AllowUserToDeleteRows = false;
            this.dgvStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(6, 59);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Size = new System.Drawing.Size(685, 159);
            this.dgvStatus.TabIndex = 0;
            this.dgvStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEstados_CellClick);
            // 
            // FormOtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelResultado);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOtros";
            this.Text = "FormOtros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearTipoGasto;
        private System.Windows.Forms.Button btnBuscarTodosGastos;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnEditarEstado;
        private System.Windows.Forms.Button btnAgregarEstado;
        private System.Windows.Forms.Button btnMostrarEstados;
        private System.Windows.Forms.DataGridView dgvStatus;
    }
}