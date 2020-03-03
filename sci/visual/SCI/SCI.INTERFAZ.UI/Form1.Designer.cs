namespace SCI.INTERFAZ.UI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelReportesSubMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelViajesSubMenu = new System.Windows.Forms.Panel();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.panelCatalogoSubMenu = new System.Windows.Forms.Panel();
            this.btnGasolineria = new System.Windows.Forms.Button();
            this.btnCasetas = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnOperadores = new System.Windows.Forms.Button();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelViajesSubMenu.SuspendLayout();
            this.panelCatalogoSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panelSideMenu.Controls.Add(this.panelReportesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.panelViajesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTransporte);
            this.panelSideMenu.Controls.Add(this.panelCatalogoSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCatalogos);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 661);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelReportesSubMenu
            // 
            this.panelReportesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panelReportesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportesSubMenu.Location = new System.Drawing.Point(0, 546);
            this.panelReportesSubMenu.Name = "panelReportesSubMenu";
            this.panelReportesSubMenu.Size = new System.Drawing.Size(233, 132);
            this.panelReportesSubMenu.TabIndex = 5;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 501);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(233, 45);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "             Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelViajesSubMenu
            // 
            this.panelViajesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panelViajesSubMenu.Controls.Add(this.btnViajes);
            this.panelViajesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViajesSubMenu.Location = new System.Drawing.Point(0, 452);
            this.panelViajesSubMenu.Name = "panelViajesSubMenu";
            this.panelViajesSubMenu.Size = new System.Drawing.Size(233, 49);
            this.panelViajesSubMenu.TabIndex = 3;
            // 
            // btnViajes
            // 
            this.btnViajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViajes.FlatAppearance.BorderSize = 0;
            this.btnViajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViajes.ForeColor = System.Drawing.Color.LightGray;
            this.btnViajes.Image = ((System.Drawing.Image)(resources.GetObject("btnViajes.Image")));
            this.btnViajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViajes.Location = new System.Drawing.Point(0, 0);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnViajes.Size = new System.Drawing.Size(233, 40);
            this.btnViajes.TabIndex = 0;
            this.btnViajes.Text = "             Viajes";
            this.btnViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnTransporte
            // 
            this.btnTransporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransporte.FlatAppearance.BorderSize = 0;
            this.btnTransporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransporte.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransporte.Image = ((System.Drawing.Image)(resources.GetObject("btnTransporte.Image")));
            this.btnTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransporte.Location = new System.Drawing.Point(0, 407);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(233, 45);
            this.btnTransporte.TabIndex = 2;
            this.btnTransporte.Text = "             Transportes";
            this.btnTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransporte.UseVisualStyleBackColor = true;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // panelCatalogoSubMenu
            // 
            this.panelCatalogoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panelCatalogoSubMenu.Controls.Add(this.btnGasolineria);
            this.panelCatalogoSubMenu.Controls.Add(this.btnCasetas);
            this.panelCatalogoSubMenu.Controls.Add(this.btnGastos);
            this.panelCatalogoSubMenu.Controls.Add(this.btnRutas);
            this.panelCatalogoSubMenu.Controls.Add(this.btnClientes);
            this.panelCatalogoSubMenu.Controls.Add(this.btnOperadores);
            this.panelCatalogoSubMenu.Controls.Add(this.btnUnidades);
            this.panelCatalogoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogoSubMenu.Location = new System.Drawing.Point(0, 114);
            this.panelCatalogoSubMenu.Name = "panelCatalogoSubMenu";
            this.panelCatalogoSubMenu.Size = new System.Drawing.Size(233, 293);
            this.panelCatalogoSubMenu.TabIndex = 1;
            // 
            // btnGasolineria
            // 
            this.btnGasolineria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGasolineria.FlatAppearance.BorderSize = 0;
            this.btnGasolineria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGasolineria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGasolineria.ForeColor = System.Drawing.Color.LightGray;
            this.btnGasolineria.Image = ((System.Drawing.Image)(resources.GetObject("btnGasolineria.Image")));
            this.btnGasolineria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGasolineria.Location = new System.Drawing.Point(0, 240);
            this.btnGasolineria.Name = "btnGasolineria";
            this.btnGasolineria.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGasolineria.Size = new System.Drawing.Size(233, 40);
            this.btnGasolineria.TabIndex = 6;
            this.btnGasolineria.Text = "             Gasolinerías";
            this.btnGasolineria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGasolineria.UseVisualStyleBackColor = true;
            this.btnGasolineria.Click += new System.EventHandler(this.btnGasolineria_Click);
            // 
            // btnCasetas
            // 
            this.btnCasetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCasetas.FlatAppearance.BorderSize = 0;
            this.btnCasetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCasetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasetas.ForeColor = System.Drawing.Color.LightGray;
            this.btnCasetas.Image = ((System.Drawing.Image)(resources.GetObject("btnCasetas.Image")));
            this.btnCasetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCasetas.Location = new System.Drawing.Point(0, 200);
            this.btnCasetas.Name = "btnCasetas";
            this.btnCasetas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCasetas.Size = new System.Drawing.Size(233, 40);
            this.btnCasetas.TabIndex = 5;
            this.btnCasetas.Text = "             Casetas";
            this.btnCasetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCasetas.UseVisualStyleBackColor = true;
            this.btnCasetas.Click += new System.EventHandler(this.btnCasetas_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.ForeColor = System.Drawing.Color.LightGray;
            this.btnGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnGastos.Image")));
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(0, 160);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGastos.Size = new System.Drawing.Size(233, 40);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "             Tipos Gastos y Status";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.ForeColor = System.Drawing.Color.LightGray;
            this.btnRutas.Image = ((System.Drawing.Image)(resources.GetObject("btnRutas.Image")));
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.Location = new System.Drawing.Point(0, 120);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRutas.Size = new System.Drawing.Size(233, 40);
            this.btnRutas.TabIndex = 3;
            this.btnRutas.Text = "             Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.LightGray;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 80);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(233, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "             Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOperadores
            // 
            this.btnOperadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperadores.FlatAppearance.BorderSize = 0;
            this.btnOperadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnOperadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperadores.ForeColor = System.Drawing.Color.LightGray;
            this.btnOperadores.Image = ((System.Drawing.Image)(resources.GetObject("btnOperadores.Image")));
            this.btnOperadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperadores.Location = new System.Drawing.Point(0, 40);
            this.btnOperadores.Name = "btnOperadores";
            this.btnOperadores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOperadores.Size = new System.Drawing.Size(233, 40);
            this.btnOperadores.TabIndex = 1;
            this.btnOperadores.Text = "             Operadores";
            this.btnOperadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperadores.UseVisualStyleBackColor = true;
            this.btnOperadores.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUnidades
            // 
            this.btnUnidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnidades.FlatAppearance.BorderSize = 0;
            this.btnUnidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidades.ForeColor = System.Drawing.Color.LightGray;
            this.btnUnidades.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidades.Image")));
            this.btnUnidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnidades.Location = new System.Drawing.Point(0, 0);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUnidades.Size = new System.Drawing.Size(233, 40);
            this.btnUnidades.TabIndex = 0;
            this.btnUnidades.Text = "             Unidades";
            this.btnUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnidades.UseVisualStyleBackColor = true;
            this.btnUnidades.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogos.FlatAppearance.BorderSize = 0;
            this.btnCatalogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCatalogos.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogos.Image")));
            this.btnCatalogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.Location = new System.Drawing.Point(0, 69);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Size = new System.Drawing.Size(233, 45);
            this.btnCatalogos.TabIndex = 0;
            this.btnCatalogos.Text = "             Catalogos";
            this.btnCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.UseVisualStyleBackColor = true;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashBoard.BackColor = System.Drawing.Color.White;
            this.panelDashBoard.Controls.Add(this.pictureBox1);
            this.panelDashBoard.Location = new System.Drawing.Point(250, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(1084, 661);
            this.panelDashBoard.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.panelDashBoard);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1380, 780);
            this.MinimumSize = new System.Drawing.Size(1350, 700);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Control de Servicios Corporativos Integrales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelViajesSubMenu.ResumeLayout(false);
            this.panelCatalogoSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCatalogoSubMenu;
        private System.Windows.Forms.Button btnCatalogos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnidades;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelViajesSubMenu;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnTransporte;
        private System.Windows.Forms.Panel panelReportesSubMenu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnOperadores;
        private System.Windows.Forms.Button btnGasolineria;
        private System.Windows.Forms.Button btnCasetas;
    }
}

