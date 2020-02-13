namespace SCI.INTERFAZ.UI
{
    partial class FormViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViajes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarViaje = new System.Windows.Forms.Button();
            this.btnEditarViaje = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnBuscarTodosViajes = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
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
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para revisar los viajes.";
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
            this.groupBox1.Controls.Add(this.comboStatus);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEliminarViaje);
            this.groupBox1.Controls.Add(this.btnEditarViaje);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearViaje);
            this.groupBox1.Controls.Add(this.btnBuscarTodosViajes);
            this.groupBox1.Controls.Add(this.dgvViajes);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 477);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Todos los Viajes";
            // 
            // comboStatus
            // 
            this.comboStatus.BackColor = System.Drawing.SystemColors.Window;
            this.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "En Planeacion",
            "En Transito"});
            this.comboStatus.Location = new System.Drawing.Point(6, 24);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(130, 25);
            this.comboStatus.TabIndex = 8;
            this.comboStatus.Text = "En Planeación";
            this.comboStatus.SelectedValueChanged += new System.EventHandler(this.comboStatus_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarViaje
            // 
            this.btnEliminarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarViaje.FlatAppearance.BorderSize = 0;
            this.btnEliminarViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEliminarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarViaje.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarViaje.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarViaje.Image")));
            this.btnEliminarViaje.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarViaje.Location = new System.Drawing.Point(550, 20);
            this.btnEliminarViaje.Name = "btnEliminarViaje";
            this.btnEliminarViaje.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarViaje.TabIndex = 4;
            this.btnEliminarViaje.Text = "Eliminar Viaje";
            this.btnEliminarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarViaje.UseVisualStyleBackColor = false;
            this.btnEliminarViaje.Click += new System.EventHandler(this.btnEliminarViaje_Click);
            // 
            // btnEditarViaje
            // 
            this.btnEditarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarViaje.FlatAppearance.BorderSize = 0;
            this.btnEditarViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEditarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarViaje.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarViaje.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarViaje.Image")));
            this.btnEditarViaje.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarViaje.Location = new System.Drawing.Point(414, 20);
            this.btnEditarViaje.Name = "btnEditarViaje";
            this.btnEditarViaje.Size = new System.Drawing.Size(130, 33);
            this.btnEditarViaje.TabIndex = 3;
            this.btnEditarViaje.Text = "Editar Viaje";
            this.btnEditarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarViaje.UseVisualStyleBackColor = false;
            this.btnEditarViaje.Click += new System.EventHandler(this.btnEditarViaje_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panelResultado.Controls.Add(this.labelResultado);
            this.panelResultado.Controls.Add(this.label2);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelResultado.Location = new System.Drawing.Point(3, 454);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(691, 20);
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
            // btnCrearViaje
            // 
            this.btnCrearViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearViaje.FlatAppearance.BorderSize = 0;
            this.btnCrearViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCrearViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearViaje.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearViaje.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearViaje.Image")));
            this.btnCrearViaje.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearViaje.Location = new System.Drawing.Point(278, 20);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(130, 33);
            this.btnCrearViaje.TabIndex = 2;
            this.btnCrearViaje.Text = "Agregar Viaje";
            this.btnCrearViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearViaje.UseVisualStyleBackColor = false;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // btnBuscarTodosViajes
            // 
            this.btnBuscarTodosViajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnBuscarTodosViajes.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodosViajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnBuscarTodosViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodosViajes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarTodosViajes.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodosViajes.Image")));
            this.btnBuscarTodosViajes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarTodosViajes.Location = new System.Drawing.Point(142, 20);
            this.btnBuscarTodosViajes.Name = "btnBuscarTodosViajes";
            this.btnBuscarTodosViajes.Size = new System.Drawing.Size(130, 33);
            this.btnBuscarTodosViajes.TabIndex = 1;
            this.btnBuscarTodosViajes.Text = "Mostrar Todos";
            this.btnBuscarTodosViajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodosViajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodosViajes.UseVisualStyleBackColor = false;
            this.btnBuscarTodosViajes.Click += new System.EventHandler(this.btnBuscarTodosViajes_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.AllowUserToOrderColumns = true;
            this.dgvViajes.AllowUserToResizeRows = false;
            this.dgvViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvViajes.BackgroundColor = System.Drawing.Color.White;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.EnableHeadersVisualStyles = false;
            this.dgvViajes.Location = new System.Drawing.Point(6, 59);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.Size = new System.Drawing.Size(685, 389);
            this.dgvViajes.TabIndex = 0;
            this.dgvViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellClick);
            this.dgvViajes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViajes_ColumnHeaderMouseClick);
            // 
            // FormViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormViajes";
            this.Text = "FormViajes";
            this.Load += new System.EventHandler(this.FormViajes_Load);
            this.Shown += new System.EventHandler(this.FormViajes_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarViaje;
        private System.Windows.Forms.Button btnEditarViaje;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnBuscarTodosViajes;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.ComboBox comboStatus;
    }
}