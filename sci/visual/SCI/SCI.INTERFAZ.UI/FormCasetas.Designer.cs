namespace SCI.INTERFAZ.UI
{
    partial class FormCasetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCasetas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnElminarCaseta = new System.Windows.Forms.Button();
            this.btnEditarCaseta = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearCaseta = new System.Windows.Forms.Button();
            this.btnBuscarTodasCasetas = new System.Windows.Forms.Button();
            this.dgvCasetas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasetas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnElminarCaseta);
            this.groupBox1.Controls.Add(this.btnEditarCaseta);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearCaseta);
            this.groupBox1.Controls.Add(this.btnBuscarTodasCasetas);
            this.groupBox1.Controls.Add(this.dgvCasetas);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 477);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Todos las casetas";
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
            // btnElminarCaseta
            // 
            this.btnElminarCaseta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnElminarCaseta.FlatAppearance.BorderSize = 0;
            this.btnElminarCaseta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnElminarCaseta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElminarCaseta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnElminarCaseta.Image = ((System.Drawing.Image)(resources.GetObject("btnElminarCaseta.Image")));
            this.btnElminarCaseta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnElminarCaseta.Location = new System.Drawing.Point(414, 20);
            this.btnElminarCaseta.Name = "btnElminarCaseta";
            this.btnElminarCaseta.Size = new System.Drawing.Size(130, 33);
            this.btnElminarCaseta.TabIndex = 4;
            this.btnElminarCaseta.Text = "Eliminar Caseta";
            this.btnElminarCaseta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElminarCaseta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElminarCaseta.UseVisualStyleBackColor = false;
            this.btnElminarCaseta.Click += new System.EventHandler(this.btnElminarCaseta_Click);
            // 
            // btnEditarCaseta
            // 
            this.btnEditarCaseta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarCaseta.FlatAppearance.BorderSize = 0;
            this.btnEditarCaseta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEditarCaseta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCaseta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarCaseta.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCaseta.Image")));
            this.btnEditarCaseta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarCaseta.Location = new System.Drawing.Point(278, 20);
            this.btnEditarCaseta.Name = "btnEditarCaseta";
            this.btnEditarCaseta.Size = new System.Drawing.Size(130, 33);
            this.btnEditarCaseta.TabIndex = 3;
            this.btnEditarCaseta.Text = "Editar Caseta";
            this.btnEditarCaseta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCaseta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCaseta.UseVisualStyleBackColor = false;
            this.btnEditarCaseta.Click += new System.EventHandler(this.btnEditarCaseta_Click);
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
            // btnCrearCaseta
            // 
            this.btnCrearCaseta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearCaseta.FlatAppearance.BorderSize = 0;
            this.btnCrearCaseta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCrearCaseta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCaseta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearCaseta.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearCaseta.Image")));
            this.btnCrearCaseta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearCaseta.Location = new System.Drawing.Point(142, 20);
            this.btnCrearCaseta.Name = "btnCrearCaseta";
            this.btnCrearCaseta.Size = new System.Drawing.Size(130, 33);
            this.btnCrearCaseta.TabIndex = 2;
            this.btnCrearCaseta.Text = "Agregar Caseta";
            this.btnCrearCaseta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearCaseta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCaseta.UseVisualStyleBackColor = false;
            this.btnCrearCaseta.Click += new System.EventHandler(this.btnCrearCaseta_Click);
            // 
            // btnBuscarTodasCasetas
            // 
            this.btnBuscarTodasCasetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnBuscarTodasCasetas.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodasCasetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBuscarTodasCasetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodasCasetas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarTodasCasetas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodasCasetas.Image")));
            this.btnBuscarTodasCasetas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarTodasCasetas.Location = new System.Drawing.Point(6, 20);
            this.btnBuscarTodasCasetas.Name = "btnBuscarTodasCasetas";
            this.btnBuscarTodasCasetas.Size = new System.Drawing.Size(130, 33);
            this.btnBuscarTodasCasetas.TabIndex = 1;
            this.btnBuscarTodasCasetas.Text = "Mostrar Todas";
            this.btnBuscarTodasCasetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodasCasetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodasCasetas.UseVisualStyleBackColor = false;
            this.btnBuscarTodasCasetas.Click += new System.EventHandler(this.btnBuscarTodasCasetas_Click);
            // 
            // dgvCasetas
            // 
            this.dgvCasetas.AllowUserToAddRows = false;
            this.dgvCasetas.AllowUserToDeleteRows = false;
            this.dgvCasetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCasetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCasetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCasetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasetas.Location = new System.Drawing.Point(6, 59);
            this.dgvCasetas.Name = "dgvCasetas";
            this.dgvCasetas.ReadOnly = true;
            this.dgvCasetas.Size = new System.Drawing.Size(685, 389);
            this.dgvCasetas.TabIndex = 0;
            this.dgvCasetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasetas_CellClick);
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
            this.label1.Size = new System.Drawing.Size(386, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para agregar nuevas Casetas, modificarlas o darlas de bajar.";
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
            // FormCasetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormCasetas";
            this.Text = "FormCasetas";
            this.Load += new System.EventHandler(this.FormCasetas_Load);
            this.Shown += new System.EventHandler(this.FormCasetas_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasetas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnElminarCaseta;
        private System.Windows.Forms.Button btnEditarCaseta;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearCaseta;
        private System.Windows.Forms.Button btnBuscarTodasCasetas;
        private System.Windows.Forms.DataGridView dgvCasetas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}