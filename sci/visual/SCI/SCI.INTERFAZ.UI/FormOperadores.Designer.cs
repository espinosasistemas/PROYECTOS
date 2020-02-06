namespace SCI.INTERFAZ.UI
{
    partial class FormOperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperadores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarOperador = new System.Windows.Forms.Button();
            this.btnEditarOperador = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearOperador = new System.Windows.Forms.Button();
            this.btnMostrarOperadores = new System.Windows.Forms.Button();
            this.dgvOperadores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEliminarOperador);
            this.groupBox1.Controls.Add(this.btnEditarOperador);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearOperador);
            this.groupBox1.Controls.Add(this.btnMostrarOperadores);
            this.groupBox1.Controls.Add(this.dgvOperadores);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 477);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Todos los Operadores";
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
            // btnEliminarOperador
            // 
            this.btnEliminarOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarOperador.FlatAppearance.BorderSize = 0;
            this.btnEliminarOperador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEliminarOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarOperador.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarOperador.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarOperador.Image")));
            this.btnEliminarOperador.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarOperador.Location = new System.Drawing.Point(414, 20);
            this.btnEliminarOperador.Name = "btnEliminarOperador";
            this.btnEliminarOperador.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarOperador.TabIndex = 4;
            this.btnEliminarOperador.Text = "Elim Operador";
            this.btnEliminarOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOperador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarOperador.UseVisualStyleBackColor = false;
            this.btnEliminarOperador.Click += new System.EventHandler(this.btnEliminarOperador_Click);
            // 
            // btnEditarOperador
            // 
            this.btnEditarOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarOperador.FlatAppearance.BorderSize = 0;
            this.btnEditarOperador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEditarOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarOperador.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarOperador.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarOperador.Image")));
            this.btnEditarOperador.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarOperador.Location = new System.Drawing.Point(278, 20);
            this.btnEditarOperador.Name = "btnEditarOperador";
            this.btnEditarOperador.Size = new System.Drawing.Size(130, 33);
            this.btnEditarOperador.TabIndex = 3;
            this.btnEditarOperador.Text = "Edit Operador";
            this.btnEditarOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarOperador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarOperador.UseVisualStyleBackColor = false;
            this.btnEditarOperador.Click += new System.EventHandler(this.btnEditarOperador_Click);
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
            // btnCrearOperador
            // 
            this.btnCrearOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearOperador.FlatAppearance.BorderSize = 0;
            this.btnCrearOperador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCrearOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearOperador.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearOperador.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearOperador.Image")));
            this.btnCrearOperador.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearOperador.Location = new System.Drawing.Point(142, 20);
            this.btnCrearOperador.Name = "btnCrearOperador";
            this.btnCrearOperador.Size = new System.Drawing.Size(130, 33);
            this.btnCrearOperador.TabIndex = 2;
            this.btnCrearOperador.Text = "Add Operador";
            this.btnCrearOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearOperador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearOperador.UseVisualStyleBackColor = false;
            this.btnCrearOperador.Click += new System.EventHandler(this.btnCrearOperador_Click);
            // 
            // btnMostrarOperadores
            // 
            this.btnMostrarOperadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnMostrarOperadores.FlatAppearance.BorderSize = 0;
            this.btnMostrarOperadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnMostrarOperadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarOperadores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMostrarOperadores.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarOperadores.Image")));
            this.btnMostrarOperadores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMostrarOperadores.Location = new System.Drawing.Point(6, 20);
            this.btnMostrarOperadores.Name = "btnMostrarOperadores";
            this.btnMostrarOperadores.Size = new System.Drawing.Size(130, 33);
            this.btnMostrarOperadores.TabIndex = 1;
            this.btnMostrarOperadores.Text = "Mostrar Todos";
            this.btnMostrarOperadores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarOperadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarOperadores.UseVisualStyleBackColor = false;
            this.btnMostrarOperadores.Click += new System.EventHandler(this.btnMostrarOperadores_Click);
            // 
            // dgvOperadores
            // 
            this.dgvOperadores.AllowUserToAddRows = false;
            this.dgvOperadores.AllowUserToDeleteRows = false;
            this.dgvOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOperadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperadores.Location = new System.Drawing.Point(6, 59);
            this.dgvOperadores.Name = "dgvOperadores";
            this.dgvOperadores.ReadOnly = true;
            this.dgvOperadores.Size = new System.Drawing.Size(685, 389);
            this.dgvOperadores.TabIndex = 0;
            this.dgvOperadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperadores_CellClick);
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para agregar nuevos Operadores, modificarlos o darlos de bajar.";
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
            // FormOperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOperadores";
            this.Text = "FormOperadores";
            this.Load += new System.EventHandler(this.FormOperadores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarOperador;
        private System.Windows.Forms.Button btnEditarOperador;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearOperador;
        private System.Windows.Forms.Button btnMostrarOperadores;
        private System.Windows.Forms.DataGridView dgvOperadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}