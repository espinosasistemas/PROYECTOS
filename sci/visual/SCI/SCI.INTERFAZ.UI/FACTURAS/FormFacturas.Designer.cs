namespace SCI.INTERFAZ.UI
{
    partial class FormFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.btnStatusFacturas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.btnEditarFactura = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnBuscarTodasFacturas = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 26);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para revisar las facturas";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(857, 3);
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
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listBoxStatus);
            this.groupBox1.Controls.Add(this.btnStatusFacturas);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEliminarFactura);
            this.groupBox1.Controls.Add(this.btnEditarFactura);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearFactura);
            this.groupBox1.Controls.Add(this.btnBuscarTodasFacturas);
            this.groupBox1.Controls.Add(this.dgvFacturas);
            this.groupBox1.Location = new System.Drawing.Point(0, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 541);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Items.AddRange(new object[] {
            "Planeacion",
            "Transito",
            "Detenido",
            "Entregado"});
            this.listBoxStatus.Location = new System.Drawing.Point(6, 53);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(130, 116);
            this.listBoxStatus.TabIndex = 9;
            this.listBoxStatus.Visible = false;
            // 
            // btnStatusFacturas
            // 
            this.btnStatusFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnStatusFacturas.FlatAppearance.BorderSize = 0;
            this.btnStatusFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnStatusFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusFacturas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatusFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusFacturas.Image")));
            this.btnStatusFacturas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStatusFacturas.Location = new System.Drawing.Point(6, 20);
            this.btnStatusFacturas.Name = "btnStatusFacturas";
            this.btnStatusFacturas.Size = new System.Drawing.Size(130, 33);
            this.btnStatusFacturas.TabIndex = 1;
            this.btnStatusFacturas.Text = "Elegir Status";
            this.btnStatusFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatusFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatusFacturas.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(808, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarFactura.FlatAppearance.BorderSize = 0;
            this.btnEliminarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFactura.Image")));
            this.btnEliminarFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarFactura.Location = new System.Drawing.Point(550, 20);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarFactura.TabIndex = 5;
            this.btnEliminarFactura.Text = "Eliminar Factura";
            this.btnEliminarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarFactura.UseVisualStyleBackColor = false;
            // 
            // btnEditarFactura
            // 
            this.btnEditarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarFactura.FlatAppearance.BorderSize = 0;
            this.btnEditarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEditarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFactura.Image")));
            this.btnEditarFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarFactura.Location = new System.Drawing.Point(414, 20);
            this.btnEditarFactura.Name = "btnEditarFactura";
            this.btnEditarFactura.Size = new System.Drawing.Size(130, 33);
            this.btnEditarFactura.TabIndex = 4;
            this.btnEditarFactura.Text = "Editar Factura";
            this.btnEditarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarFactura.UseVisualStyleBackColor = false;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panelResultado.Controls.Add(this.labelResultado);
            this.panelResultado.Controls.Add(this.label2);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelResultado.Location = new System.Drawing.Point(3, 508);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(878, 30);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(191, 6);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(72, 17);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado de la operación: ";
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearFactura.FlatAppearance.BorderSize = 0;
            this.btnCrearFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearFactura.Image")));
            this.btnCrearFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearFactura.Location = new System.Drawing.Point(278, 20);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(130, 33);
            this.btnCrearFactura.TabIndex = 3;
            this.btnCrearFactura.Text = "Agregar Factura";
            this.btnCrearFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnBuscarTodasFacturas
            // 
            this.btnBuscarTodasFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnBuscarTodasFacturas.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodasFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBuscarTodasFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodasFacturas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarTodasFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodasFacturas.Image")));
            this.btnBuscarTodasFacturas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarTodasFacturas.Location = new System.Drawing.Point(142, 20);
            this.btnBuscarTodasFacturas.Name = "btnBuscarTodasFacturas";
            this.btnBuscarTodasFacturas.Size = new System.Drawing.Size(130, 33);
            this.btnBuscarTodasFacturas.TabIndex = 2;
            this.btnBuscarTodasFacturas.Text = "Mostrar Todas";
            this.btnBuscarTodasFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodasFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodasFacturas.UseVisualStyleBackColor = false;
            this.btnBuscarTodasFacturas.Click += new System.EventHandler(this.btnBuscarTodasFacturas_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToOrderColumns = true;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.Location = new System.Drawing.Point(6, 59);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(872, 443);
            this.dgvFacturas.TabIndex = 0;
            // 
            // FormFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFacturas";
            this.Text = "FormFacturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button btnStatusFacturas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.Button btnEditarFactura;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnBuscarTodasFacturas;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}