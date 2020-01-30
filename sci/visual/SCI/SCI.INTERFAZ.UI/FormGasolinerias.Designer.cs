namespace SCI.INTERFAZ.UI
{
    partial class FormGasolinerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGasolinerias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnElminarGasolineria = new System.Windows.Forms.Button();
            this.btnEditarGasolineria = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearGasolineria = new System.Windows.Forms.Button();
            this.btnBuscarTodasGasolinerias = new System.Windows.Forms.Button();
            this.dgvGasolinerias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasolinerias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnElminarGasolineria);
            this.groupBox1.Controls.Add(this.btnEditarGasolineria);
            this.groupBox1.Controls.Add(this.panelResultado);
            this.groupBox1.Controls.Add(this.btnCrearGasolineria);
            this.groupBox1.Controls.Add(this.btnBuscarTodasGasolinerias);
            this.groupBox1.Controls.Add(this.dgvGasolinerias);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 477);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Todos las gasolinerías";
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
            // btnElminarGasolineria
            // 
            this.btnElminarGasolineria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnElminarGasolineria.FlatAppearance.BorderSize = 0;
            this.btnElminarGasolineria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnElminarGasolineria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElminarGasolineria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnElminarGasolineria.Image = ((System.Drawing.Image)(resources.GetObject("btnElminarGasolineria.Image")));
            this.btnElminarGasolineria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnElminarGasolineria.Location = new System.Drawing.Point(414, 20);
            this.btnElminarGasolineria.Name = "btnElminarGasolineria";
            this.btnElminarGasolineria.Size = new System.Drawing.Size(130, 33);
            this.btnElminarGasolineria.TabIndex = 5;
            this.btnElminarGasolineria.Text = "Elim Gasolinería";
            this.btnElminarGasolineria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElminarGasolineria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElminarGasolineria.UseVisualStyleBackColor = false;
            this.btnElminarGasolineria.Click += new System.EventHandler(this.btnElminarGasolineria_Click);
            // 
            // btnEditarGasolineria
            // 
            this.btnEditarGasolineria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEditarGasolineria.FlatAppearance.BorderSize = 0;
            this.btnEditarGasolineria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEditarGasolineria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGasolineria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarGasolineria.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGasolineria.Image")));
            this.btnEditarGasolineria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarGasolineria.Location = new System.Drawing.Point(278, 20);
            this.btnEditarGasolineria.Name = "btnEditarGasolineria";
            this.btnEditarGasolineria.Size = new System.Drawing.Size(130, 33);
            this.btnEditarGasolineria.TabIndex = 4;
            this.btnEditarGasolineria.Text = "Edit Gasolinería";
            this.btnEditarGasolineria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarGasolineria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarGasolineria.UseVisualStyleBackColor = false;
            this.btnEditarGasolineria.Click += new System.EventHandler(this.btnEditarGasolineria_Click);
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
            // btnCrearGasolineria
            // 
            this.btnCrearGasolineria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrearGasolineria.FlatAppearance.BorderSize = 0;
            this.btnCrearGasolineria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCrearGasolineria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearGasolineria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearGasolineria.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearGasolineria.Image")));
            this.btnCrearGasolineria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearGasolineria.Location = new System.Drawing.Point(142, 20);
            this.btnCrearGasolineria.Name = "btnCrearGasolineria";
            this.btnCrearGasolineria.Size = new System.Drawing.Size(130, 33);
            this.btnCrearGasolineria.TabIndex = 2;
            this.btnCrearGasolineria.Text = "Add Gasolinería";
            this.btnCrearGasolineria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearGasolineria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearGasolineria.UseVisualStyleBackColor = false;
            this.btnCrearGasolineria.Click += new System.EventHandler(this.btnCrearGasolineria_Click);
            // 
            // btnBuscarTodasGasolinerias
            // 
            this.btnBuscarTodasGasolinerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnBuscarTodasGasolinerias.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodasGasolinerias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnBuscarTodasGasolinerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodasGasolinerias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarTodasGasolinerias.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodasGasolinerias.Image")));
            this.btnBuscarTodasGasolinerias.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarTodasGasolinerias.Location = new System.Drawing.Point(6, 20);
            this.btnBuscarTodasGasolinerias.Name = "btnBuscarTodasGasolinerias";
            this.btnBuscarTodasGasolinerias.Size = new System.Drawing.Size(130, 33);
            this.btnBuscarTodasGasolinerias.TabIndex = 1;
            this.btnBuscarTodasGasolinerias.Text = "Mostrar Todas";
            this.btnBuscarTodasGasolinerias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodasGasolinerias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodasGasolinerias.UseVisualStyleBackColor = false;
            this.btnBuscarTodasGasolinerias.Click += new System.EventHandler(this.btnBuscarTodasGasolinerias_Click);
            // 
            // dgvGasolinerias
            // 
            this.dgvGasolinerias.AllowUserToAddRows = false;
            this.dgvGasolinerias.AllowUserToDeleteRows = false;
            this.dgvGasolinerias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGasolinerias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGasolinerias.BackgroundColor = System.Drawing.Color.White;
            this.dgvGasolinerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasolinerias.Location = new System.Drawing.Point(6, 59);
            this.dgvGasolinerias.Name = "dgvGasolinerias";
            this.dgvGasolinerias.ReadOnly = true;
            this.dgvGasolinerias.Size = new System.Drawing.Size(685, 389);
            this.dgvGasolinerias.TabIndex = 0;
            this.dgvGasolinerias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGasolinerias_CellClick);
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
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo para agregar nuevas Gasolinerias, modificarlas o darlas de bajar.";
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
            // 
            // FormGasolinerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormGasolinerias";
            this.Text = "FormGasolinerias";
            this.Load += new System.EventHandler(this.FormGasolinerias_Load);
            this.Shown += new System.EventHandler(this.FormGasolinerias_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasolinerias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnElminarGasolineria;
        private System.Windows.Forms.Button btnEditarGasolineria;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearGasolineria;
        private System.Windows.Forms.Button btnBuscarTodasGasolinerias;
        private System.Windows.Forms.DataGridView dgvGasolinerias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}