namespace SCI.INTERFAZ.UI
{
    partial class FormAgregarDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarDeposito));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarDeposito = new System.Windows.Forms.Button();
            this.textReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.labelNombreOperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTipoDeposito = new System.Windows.Forms.ComboBox();
            this.btnAgregarDeposito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminarDeposito);
            this.groupBox1.Controls.Add(this.textReferencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvDepositos);
            this.groupBox1.Controls.Add(this.labelNombreOperador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboTipoDeposito);
            this.groupBox1.Controls.Add(this.btnAgregarDeposito);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textMonto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 390);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa los datos de la Ruta";
            // 
            // btnEliminarDeposito
            // 
            this.btnEliminarDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnEliminarDeposito.FlatAppearance.BorderSize = 0;
            this.btnEliminarDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnEliminarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDeposito.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDeposito.Image")));
            this.btnEliminarDeposito.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarDeposito.Location = new System.Drawing.Point(227, 166);
            this.btnEliminarDeposito.Name = "btnEliminarDeposito";
            this.btnEliminarDeposito.Size = new System.Drawing.Size(104, 33);
            this.btnEliminarDeposito.TabIndex = 37;
            this.btnEliminarDeposito.Text = "Eliminar";
            this.btnEliminarDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDeposito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarDeposito.UseVisualStyleBackColor = false;
            this.btnEliminarDeposito.Click += new System.EventHandler(this.btnEliminarDeposito_Click);
            // 
            // textReferencia
            // 
            this.textReferencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReferencia.Location = new System.Drawing.Point(132, 125);
            this.textReferencia.Name = "textReferencia";
            this.textReferencia.Size = new System.Drawing.Size(309, 26);
            this.textReferencia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Referencia";
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.AllowUserToDeleteRows = false;
            this.dgvDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepositos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Location = new System.Drawing.Point(17, 213);
            this.dgvDepositos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.ReadOnly = true;
            this.dgvDepositos.Size = new System.Drawing.Size(427, 148);
            this.dgvDepositos.TabIndex = 36;
            this.dgvDepositos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositos_CellClick);
            // 
            // labelNombreOperador
            // 
            this.labelNombreOperador.AutoSize = true;
            this.labelNombreOperador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.labelNombreOperador.Location = new System.Drawing.Point(130, 24);
            this.labelNombreOperador.Name = "labelNombreOperador";
            this.labelNombreOperador.Size = new System.Drawing.Size(85, 19);
            this.labelNombreOperador.TabIndex = 7;
            this.labelNombreOperador.Text = "Operador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operador";
            // 
            // comboTipoDeposito
            // 
            this.comboTipoDeposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoDeposito.FormattingEnabled = true;
            this.comboTipoDeposito.Items.AddRange(new object[] {
            "Transferencia",
            "Efectivo"});
            this.comboTipoDeposito.Location = new System.Drawing.Point(133, 90);
            this.comboTipoDeposito.Name = "comboTipoDeposito";
            this.comboTipoDeposito.Size = new System.Drawing.Size(308, 29);
            this.comboTipoDeposito.TabIndex = 2;
            // 
            // btnAgregarDeposito
            // 
            this.btnAgregarDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarDeposito.FlatAppearance.BorderSize = 0;
            this.btnAgregarDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAgregarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDeposito.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDeposito.Image")));
            this.btnAgregarDeposito.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarDeposito.Location = new System.Drawing.Point(337, 166);
            this.btnAgregarDeposito.Name = "btnAgregarDeposito";
            this.btnAgregarDeposito.Size = new System.Drawing.Size(104, 33);
            this.btnAgregarDeposito.TabIndex = 4;
            this.btnAgregarDeposito.Text = "Depositor";
            this.btnAgregarDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDeposito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDeposito.UseVisualStyleBackColor = false;
            this.btnAgregarDeposito.Click += new System.EventHandler(this.btnAgregarDeposito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo De Depósito";
            // 
            // textMonto
            // 
            this.textMonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMonto.Location = new System.Drawing.Point(133, 58);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(309, 26);
            this.textMonto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto";
            // 
            // FormAgregarDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 399);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgregarDeposito";
            this.Load += new System.EventHandler(this.FormAgregarDeposito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboTipoDeposito;
        private System.Windows.Forms.Button btnAgregarDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.TextBox textReferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarDeposito;
    }
}