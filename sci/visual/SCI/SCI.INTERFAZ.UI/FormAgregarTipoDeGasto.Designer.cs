namespace SCI.INTERFAZ.UI
{
    partial class FormAgregarTipoDeGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarTipoDeGasto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarTipoGasto = new System.Windows.Forms.Button();
            this.textConcepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAgregarTipoGasto);
            this.groupBox1.Controls.Add(this.textConcepto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa el Tipo de Gasto";
            // 
            // btnAgregarTipoGasto
            // 
            this.btnAgregarTipoGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarTipoGasto.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAgregarTipoGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoGasto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarTipoGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTipoGasto.Image")));
            this.btnAgregarTipoGasto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarTipoGasto.Location = new System.Drawing.Point(283, 64);
            this.btnAgregarTipoGasto.Name = "btnAgregarTipoGasto";
            this.btnAgregarTipoGasto.Size = new System.Drawing.Size(130, 33);
            this.btnAgregarTipoGasto.TabIndex = 10;
            this.btnAgregarTipoGasto.Text = "Agregar Cliente";
            this.btnAgregarTipoGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTipoGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarTipoGasto.UseVisualStyleBackColor = false;
            this.btnAgregarTipoGasto.Click += new System.EventHandler(this.btnAgregarTipoGasto_Click);
            // 
            // textConcepto
            // 
            this.textConcepto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConcepto.Location = new System.Drawing.Point(104, 32);
            this.textConcepto.Name = "textConcepto";
            this.textConcepto.Size = new System.Drawing.Size(309, 26);
            this.textConcepto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concepto";
            // 
            // FormAgregarTipoDeGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 132);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAgregarTipoDeGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgregarTipoDeGasto";
            this.Load += new System.EventHandler(this.FormAgregarTipoDeGasto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarTipoGasto;
        private System.Windows.Forms.TextBox textConcepto;
        private System.Windows.Forms.Label label1;
    }
}