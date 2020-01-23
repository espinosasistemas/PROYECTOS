namespace SCI.INTERFAZ.UI
{
    partial class FormAgregarRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarRutas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboUnidades = new System.Windows.Forms.ComboBox();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboUnidades);
            this.groupBox1.Controls.Add(this.btnAgregarRuta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCosto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa los datos de la Ruta";
            // 
            // comboUnidades
            // 
            this.comboUnidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUnidades.FormattingEnabled = true;
            this.comboUnidades.Location = new System.Drawing.Point(105, 97);
            this.comboUnidades.Name = "comboUnidades";
            this.comboUnidades.Size = new System.Drawing.Size(308, 29);
            this.comboUnidades.TabIndex = 11;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarRuta.FlatAppearance.BorderSize = 0;
            this.btnAgregarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAgregarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRuta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRuta.Image")));
            this.btnAgregarRuta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarRuta.Location = new System.Drawing.Point(284, 144);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(130, 33);
            this.btnAgregarRuta.TabIndex = 10;
            this.btnAgregarRuta.Text = "Agregar Cliente";
            this.btnAgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarRuta.UseVisualStyleBackColor = false;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unidades";
            // 
            // textCosto
            // 
            this.textCosto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCosto.Location = new System.Drawing.Point(105, 64);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(309, 26);
            this.textCosto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Costo";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(104, 32);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(309, 26);
            this.textNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // FormAgregarRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 217);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAgregarRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgregarRutas";
            this.Load += new System.EventHandler(this.FormAgregarRutas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUnidades;
    }
}