namespace SCI.INTERFAZ.UI
{
    partial class FormUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidades));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarUnidad = new System.Windows.Forms.Button();
            this.btnEditarUnidad = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearUnidad = new System.Windows.Forms.Button();
            this.btnBuscarTodasUnidades = new System.Windows.Forms.Button();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para agregar nuevas Unidades, modificarlas o dar de bajar alguna.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEliminarUnidad);
            this.groupBox1.Controls.Add(this.btnEditarUnidad);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearUnidad);
            this.groupBox1.Controls.Add(this.btnBuscarTodasUnidades);
            this.groupBox1.Controls.Add(this.dgvUnidades);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Todas las Unidades";
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
            // btnEliminarUnidad
            // 
            this.btnEliminarUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminarUnidad.FlatAppearance.BorderSize = 0;
            this.btnEliminarUnidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEliminarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUnidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarUnidad.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarUnidad.Image")));
            this.btnEliminarUnidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarUnidad.Location = new System.Drawing.Point(414, 20);
            this.btnEliminarUnidad.Name = "btnEliminarUnidad";
            this.btnEliminarUnidad.Size = new System.Drawing.Size(130, 33);
            this.btnEliminarUnidad.TabIndex = 5;
            this.btnEliminarUnidad.Text = "Eliminar Unidad";
            this.btnEliminarUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUnidad.UseVisualStyleBackColor = false;
            this.btnEliminarUnidad.Click += new System.EventHandler(this.btnEliminarUnidad_Click);
            // 
            // btnEditarUnidad
            // 
            this.btnEditarUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarUnidad.FlatAppearance.BorderSize = 0;
            this.btnEditarUnidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEditarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUnidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarUnidad.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUnidad.Image")));
            this.btnEditarUnidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarUnidad.Location = new System.Drawing.Point(278, 20);
            this.btnEditarUnidad.Name = "btnEditarUnidad";
            this.btnEditarUnidad.Size = new System.Drawing.Size(130, 33);
            this.btnEditarUnidad.TabIndex = 4;
            this.btnEditarUnidad.Text = "Editar Unidad";
            this.btnEditarUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUnidad.UseVisualStyleBackColor = false;
            this.btnEditarUnidad.Click += new System.EventHandler(this.btnEditarUnidad_Click);
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
            // btnCrearUnidad
            // 
            this.btnCrearUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearUnidad.FlatAppearance.BorderSize = 0;
            this.btnCrearUnidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCrearUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUnidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearUnidad.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearUnidad.Image")));
            this.btnCrearUnidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearUnidad.Location = new System.Drawing.Point(142, 20);
            this.btnCrearUnidad.Name = "btnCrearUnidad";
            this.btnCrearUnidad.Size = new System.Drawing.Size(130, 33);
            this.btnCrearUnidad.TabIndex = 2;
            this.btnCrearUnidad.Text = "Agregar Unidad";
            this.btnCrearUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUnidad.UseVisualStyleBackColor = false;
            this.btnCrearUnidad.Click += new System.EventHandler(this.btnCrearUnidad_Click);
            // 
            // btnBuscarTodasUnidades
            // 
            this.btnBuscarTodasUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnBuscarTodasUnidades.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodasUnidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnBuscarTodasUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodasUnidades.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarTodasUnidades.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodasUnidades.Image")));
            this.btnBuscarTodasUnidades.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarTodasUnidades.Location = new System.Drawing.Point(6, 20);
            this.btnBuscarTodasUnidades.Name = "btnBuscarTodasUnidades";
            this.btnBuscarTodasUnidades.Size = new System.Drawing.Size(130, 33);
            this.btnBuscarTodasUnidades.TabIndex = 1;
            this.btnBuscarTodasUnidades.Text = "Mostrar Todos";
            this.btnBuscarTodasUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodasUnidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodasUnidades.UseVisualStyleBackColor = false;
            this.btnBuscarTodasUnidades.Click += new System.EventHandler(this.btnBuscarTodasUnidades_Click);
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToDeleteRows = false;
            this.dgvUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Location = new System.Drawing.Point(6, 59);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.Size = new System.Drawing.Size(685, 389);
            this.dgvUnidades.TabIndex = 0;
            this.dgvUnidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellClick);
            // 
            // FormUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUnidades";
            this.Text = "FormUnidades";
            this.Load += new System.EventHandler(this.FormUnidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.Button btnBuscarTodasUnidades;
        private System.Windows.Forms.Button btnCrearUnidad;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarUnidad;
        private System.Windows.Forms.Button btnEliminarUnidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}