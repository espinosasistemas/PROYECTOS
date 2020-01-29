namespace SCI.INTERFAZ.UI
{
    partial class FormAgregarUnidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarUnidad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrearUnidad = new System.Windows.Forms.Button();
            this.comboTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPlacas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumEco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreUnidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoDeUnidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboTipoDeUnidad);
            this.groupBox1.Controls.Add(this.btnCrearUnidad);
            this.groupBox1.Controls.Add(this.comboTipoCombustible);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textNumSerie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textPlacas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNumEco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNombreUnidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa los datos de la unidad";
            // 
            // btnCrearUnidad
            // 
            this.btnCrearUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCrearUnidad.FlatAppearance.BorderSize = 0;
            this.btnCrearUnidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCrearUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUnidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearUnidad.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearUnidad.Image")));
            this.btnCrearUnidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrearUnidad.Location = new System.Drawing.Point(235, 241);
            this.btnCrearUnidad.Name = "btnCrearUnidad";
            this.btnCrearUnidad.Size = new System.Drawing.Size(130, 33);
            this.btnCrearUnidad.TabIndex = 10;
            this.btnCrearUnidad.Text = "Agregar Unidad";
            this.btnCrearUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUnidad.UseVisualStyleBackColor = false;
            this.btnCrearUnidad.Click += new System.EventHandler(this.btnCrearUnidad_Click);
            // 
            // comboTipoCombustible
            // 
            this.comboTipoCombustible.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoCombustible.FormattingEnabled = true;
            this.comboTipoCombustible.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel"});
            this.comboTipoCombustible.Location = new System.Drawing.Point(134, 163);
            this.comboTipoCombustible.Name = "comboTipoCombustible";
            this.comboTipoCombustible.Size = new System.Drawing.Size(231, 28);
            this.comboTipoCombustible.TabIndex = 5;
            this.comboTipoCombustible.Text = "Gasolina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo De \r\nCombustible";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textNumSerie
            // 
            this.textNumSerie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumSerie.Location = new System.Drawing.Point(133, 130);
            this.textNumSerie.Name = "textNumSerie";
            this.textNumSerie.Size = new System.Drawing.Size(231, 26);
            this.textNumSerie.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Núm. Serie";
            // 
            // textPlacas
            // 
            this.textPlacas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlacas.Location = new System.Drawing.Point(134, 98);
            this.textPlacas.Name = "textPlacas";
            this.textPlacas.Size = new System.Drawing.Size(231, 26);
            this.textPlacas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Placas";
            // 
            // textNumEco
            // 
            this.textNumEco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumEco.Location = new System.Drawing.Point(134, 66);
            this.textNumEco.Name = "textNumEco";
            this.textNumEco.Size = new System.Drawing.Size(231, 26);
            this.textNumEco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Núm. Económico";
            // 
            // textNombreUnidad
            // 
            this.textNombreUnidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreUnidad.Location = new System.Drawing.Point(133, 34);
            this.textNombreUnidad.Name = "textNombreUnidad";
            this.textNombreUnidad.Size = new System.Drawing.Size(231, 26);
            this.textNombreUnidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // comboTipoDeUnidad
            // 
            this.comboTipoDeUnidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoDeUnidad.FormattingEnabled = true;
            this.comboTipoDeUnidad.Location = new System.Drawing.Point(134, 197);
            this.comboTipoDeUnidad.Name = "comboTipoDeUnidad";
            this.comboTipoDeUnidad.Size = new System.Drawing.Size(231, 28);
            this.comboTipoDeUnidad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Unidad";
            // 
            // FormAgregarUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 307);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarUnidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar una Unidad Nueva";
            this.Load += new System.EventHandler(this.FormAgregarUnidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreUnidad;
        private System.Windows.Forms.TextBox textNumEco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPlacas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipoCombustible;
        private System.Windows.Forms.Button btnCrearUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTipoDeUnidad;
    }
}