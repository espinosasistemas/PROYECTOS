namespace SCI.INTERFAZ.UI
{
    partial class FormRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRutas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.btnEditarRuta = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.btnMostrarRutas = new System.Windows.Forms.Button();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEliminarRuta);
            this.groupBox1.Controls.Add(this.btnEditarRuta);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearRuta);
            this.groupBox1.Controls.Add(this.btnMostrarRutas);
            this.groupBox1.Controls.Add(this.dgvRutas);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 477);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar las Rutas dadas de Alta.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarRuta.FlatAppearance.BorderSize = 0;
            this.btnEliminarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEliminarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRuta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRuta.Image")));
            this.btnEliminarRuta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarRuta.Location = new System.Drawing.Point(414, 20);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarRuta.TabIndex = 4;
            this.btnEliminarRuta.Text = "Eliminar Ruta";
            this.btnEliminarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarRuta.UseVisualStyleBackColor = false;
            this.btnEliminarRuta.Click += new System.EventHandler(this.btnEliminarRuta_Click);
            // 
            // btnEditarRuta
            // 
            this.btnEditarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarRuta.FlatAppearance.BorderSize = 0;
            this.btnEditarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEditarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRuta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarRuta.Image")));
            this.btnEditarRuta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarRuta.Location = new System.Drawing.Point(278, 20);
            this.btnEditarRuta.Name = "btnEditarRuta";
            this.btnEditarRuta.Size = new System.Drawing.Size(130, 33);
            this.btnEditarRuta.TabIndex = 3;
            this.btnEditarRuta.Text = "Editar Ruta";
            this.btnEditarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarRuta.UseVisualStyleBackColor = false;
            this.btnEditarRuta.Click += new System.EventHandler(this.btnEditarRuta_Click);
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
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado de la operación: ";
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearRuta.FlatAppearance.BorderSize = 0;
            this.btnCrearRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCrearRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRuta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearRuta.Image")));
            this.btnCrearRuta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearRuta.Location = new System.Drawing.Point(142, 20);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(130, 33);
            this.btnCrearRuta.TabIndex = 2;
            this.btnCrearRuta.Text = "Agregar Ruta";
            this.btnCrearRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearRuta.UseVisualStyleBackColor = false;
            this.btnCrearRuta.Click += new System.EventHandler(this.btnCrearRuta_Click);
            // 
            // btnMostrarRutas
            // 
            this.btnMostrarRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnMostrarRutas.FlatAppearance.BorderSize = 0;
            this.btnMostrarRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMostrarRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRutas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMostrarRutas.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarRutas.Image")));
            this.btnMostrarRutas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMostrarRutas.Location = new System.Drawing.Point(6, 20);
            this.btnMostrarRutas.Name = "btnMostrarRutas";
            this.btnMostrarRutas.Size = new System.Drawing.Size(130, 33);
            this.btnMostrarRutas.TabIndex = 1;
            this.btnMostrarRutas.Text = "Mostrar Todas";
            this.btnMostrarRutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarRutas.UseVisualStyleBackColor = false;
            this.btnMostrarRutas.Click += new System.EventHandler(this.btnMostrarRutas_Click);
            // 
            // dgvRutas
            // 
            this.dgvRutas.AllowUserToAddRows = false;
            this.dgvRutas.AllowUserToDeleteRows = false;
            this.dgvRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRutas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRutas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRutas.Location = new System.Drawing.Point(6, 59);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.Size = new System.Drawing.Size(685, 389);
            this.dgvRutas.TabIndex = 0;
            this.dgvRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellClick);
            this.dgvRutas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellDoubleClick);
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
            this.panel1.Size = new System.Drawing.Size(718, 26);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para agregar nuevas Rutas, ligadas a una unidad.";
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
            // FormRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRutas";
            this.Text = "FormRutas";
            this.Shown += new System.EventHandler(this.FormRutas_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.Button btnEditarRuta;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.Button btnMostrarRutas;
        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}