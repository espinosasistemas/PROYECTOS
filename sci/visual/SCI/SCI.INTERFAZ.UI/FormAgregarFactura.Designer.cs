namespace SCI.INTERFAZ.UI
{
    partial class FormAgregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageReceptor = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboUsoDeCFDI = new System.Windows.Forms.ComboBox();
            this.btnBuscarClienteRFC = new System.Windows.Forms.Button();
            this.btnCargarClientes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRfc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFechaFinal = new System.Windows.Forms.Panel();
            this.btnCancelarFechaFinal = new System.Windows.Forms.Button();
            this.btnFechaHoyFinal = new System.Windows.Forms.Button();
            this.btnAceptarFechaFinal = new System.Windows.Forms.Button();
            this.calendarFinalSci = new System.Windows.Forms.MonthCalendar();
            this.trackHorasFinal = new System.Windows.Forms.TrackBar();
            this.trackMinutosFinal = new System.Windows.Forms.TrackBar();
            this.tabPageConceptos = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textClaveViaje = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageOtrosDatos = new System.Windows.Forms.TabPage();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageReceptor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelFechaFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorasFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMinutosFinal)).BeginInit();
            this.tabPageConceptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 32);
            this.panel1.TabIndex = 11;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(7, 6);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(198, 19);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Agregar o Editar Factura";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(888, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageReceptor);
            this.tabControl1.Controls.Add(this.tabPageConceptos);
            this.tabControl1.Controls.Add(this.tabPageOtrosDatos);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 475);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageReceptor
            // 
            this.tabPageReceptor.BackColor = System.Drawing.Color.Transparent;
            this.tabPageReceptor.Controls.Add(this.groupBox1);
            this.tabPageReceptor.Controls.Add(this.panelFechaFinal);
            this.tabPageReceptor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageReceptor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageReceptor.ImageKey = "(ninguno)";
            this.tabPageReceptor.Location = new System.Drawing.Point(4, 25);
            this.tabPageReceptor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageReceptor.Name = "tabPageReceptor";
            this.tabPageReceptor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageReceptor.Size = new System.Drawing.Size(888, 446);
            this.tabPageReceptor.TabIndex = 0;
            this.tabPageReceptor.Text = "Receptor";
            this.tabPageReceptor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboUsoDeCFDI);
            this.groupBox1.Controls.Add(this.btnBuscarClienteRFC);
            this.groupBox1.Controls.Add(this.btnCargarClientes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboClientes);
            this.groupBox1.Controls.Add(this.textCorreo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textRfc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 432);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // comboUsoDeCFDI
            // 
            this.comboUsoDeCFDI.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboUsoDeCFDI.FormattingEnabled = true;
            this.comboUsoDeCFDI.Items.AddRange(new object[] {
            "G01 - Adquisición de mercancias",
            "G02 - Devoluciones, descuentos o bonificaciones",
            "G03 - Gastos en general",
            "I01 - Construcciones",
            "I02 - Mobilario y equipo de oficina por inversiones",
            "I03 - Equipo de transporte",
            "I04 - Equipo de computo y accesorios",
            "I05 - Dados, troqueles, moldes, matrices y herramental",
            "I06 - Comunicaciones telefónicas",
            "I07 - Comunicaciones satelitales",
            "I08 - Otra maquinaria y equipo",
            "P01 - Por definir"});
            this.comboUsoDeCFDI.Location = new System.Drawing.Point(262, 211);
            this.comboUsoDeCFDI.Name = "comboUsoDeCFDI";
            this.comboUsoDeCFDI.Size = new System.Drawing.Size(444, 28);
            this.comboUsoDeCFDI.TabIndex = 15;
            // 
            // btnBuscarClienteRFC
            // 
            this.btnBuscarClienteRFC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteRFC.Image")));
            this.btnBuscarClienteRFC.Location = new System.Drawing.Point(675, 116);
            this.btnBuscarClienteRFC.Name = "btnBuscarClienteRFC";
            this.btnBuscarClienteRFC.Size = new System.Drawing.Size(31, 28);
            this.btnBuscarClienteRFC.TabIndex = 14;
            this.btnBuscarClienteRFC.UseVisualStyleBackColor = true;
            this.btnBuscarClienteRFC.Click += new System.EventHandler(this.btnBuscarClienteRFC_Click);
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarClientes.Image")));
            this.btnCargarClientes.Location = new System.Drawing.Point(675, 81);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(31, 30);
            this.btnCargarClientes.TabIndex = 13;
            this.btnCargarClientes.UseVisualStyleBackColor = true;
            this.btnCargarClientes.Click += new System.EventHandler(this.btnCargarClientes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clientes";
            // 
            // comboClientes
            // 
            this.comboClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(262, 82);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(413, 28);
            this.comboClientes.TabIndex = 11;
            this.comboClientes.TextChanged += new System.EventHandler(this.comboClientes_TextChanged);
            // 
            // textCorreo
            // 
            this.textCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.Location = new System.Drawing.Point(262, 181);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(444, 26);
            this.textCorreo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uso de CFDI";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(262, 149);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(444, 26);
            this.textNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de Contacto";
            // 
            // textRfc
            // 
            this.textRfc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRfc.Location = new System.Drawing.Point(262, 117);
            this.textRfc.Name = "textRfc";
            this.textRfc.Size = new System.Drawing.Size(413, 26);
            this.textRfc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC";
            // 
            // panelFechaFinal
            // 
            this.panelFechaFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panelFechaFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFechaFinal.Controls.Add(this.btnCancelarFechaFinal);
            this.panelFechaFinal.Controls.Add(this.btnFechaHoyFinal);
            this.panelFechaFinal.Controls.Add(this.btnAceptarFechaFinal);
            this.panelFechaFinal.Controls.Add(this.calendarFinalSci);
            this.panelFechaFinal.Controls.Add(this.trackHorasFinal);
            this.panelFechaFinal.Controls.Add(this.trackMinutosFinal);
            this.panelFechaFinal.Location = new System.Drawing.Point(1189, 52);
            this.panelFechaFinal.Name = "panelFechaFinal";
            this.panelFechaFinal.Size = new System.Drawing.Size(287, 340);
            this.panelFechaFinal.TabIndex = 24;
            this.panelFechaFinal.Visible = false;
            // 
            // btnCancelarFechaFinal
            // 
            this.btnCancelarFechaFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnCancelarFechaFinal.FlatAppearance.BorderSize = 0;
            this.btnCancelarFechaFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnCancelarFechaFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFechaFinal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarFechaFinal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelarFechaFinal.Location = new System.Drawing.Point(112, 298);
            this.btnCancelarFechaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarFechaFinal.Name = "btnCancelarFechaFinal";
            this.btnCancelarFechaFinal.Size = new System.Drawing.Size(67, 24);
            this.btnCancelarFechaFinal.TabIndex = 28;
            this.btnCancelarFechaFinal.Text = "Cancelar";
            this.btnCancelarFechaFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarFechaFinal.UseVisualStyleBackColor = false;
            // 
            // btnFechaHoyFinal
            // 
            this.btnFechaHoyFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnFechaHoyFinal.FlatAppearance.BorderSize = 0;
            this.btnFechaHoyFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnFechaHoyFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaHoyFinal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFechaHoyFinal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFechaHoyFinal.Location = new System.Drawing.Point(39, 298);
            this.btnFechaHoyFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechaHoyFinal.Name = "btnFechaHoyFinal";
            this.btnFechaHoyFinal.Size = new System.Drawing.Size(67, 24);
            this.btnFechaHoyFinal.TabIndex = 25;
            this.btnFechaHoyFinal.Text = "Hoy";
            this.btnFechaHoyFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechaHoyFinal.UseVisualStyleBackColor = false;
            // 
            // btnAceptarFechaFinal
            // 
            this.btnAceptarFechaFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAceptarFechaFinal.FlatAppearance.BorderSize = 0;
            this.btnAceptarFechaFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAceptarFechaFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarFechaFinal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptarFechaFinal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptarFechaFinal.Location = new System.Drawing.Point(185, 298);
            this.btnAceptarFechaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptarFechaFinal.Name = "btnAceptarFechaFinal";
            this.btnAceptarFechaFinal.Size = new System.Drawing.Size(67, 24);
            this.btnAceptarFechaFinal.TabIndex = 24;
            this.btnAceptarFechaFinal.Text = "Aceptar";
            this.btnAceptarFechaFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptarFechaFinal.UseVisualStyleBackColor = false;
            // 
            // calendarFinalSci
            // 
            this.calendarFinalSci.Location = new System.Drawing.Point(19, 17);
            this.calendarFinalSci.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calendarFinalSci.MaxSelectionCount = 30;
            this.calendarFinalSci.Name = "calendarFinalSci";
            this.calendarFinalSci.TabIndex = 11;
            // 
            // trackHorasFinal
            // 
            this.trackHorasFinal.LargeChange = 1;
            this.trackHorasFinal.Location = new System.Drawing.Point(3, 197);
            this.trackHorasFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackHorasFinal.Maximum = 23;
            this.trackHorasFinal.Name = "trackHorasFinal";
            this.trackHorasFinal.Size = new System.Drawing.Size(271, 45);
            this.trackHorasFinal.TabIndex = 21;
            // 
            // trackMinutosFinal
            // 
            this.trackMinutosFinal.LargeChange = 1;
            this.trackMinutosFinal.Location = new System.Drawing.Point(3, 247);
            this.trackMinutosFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackMinutosFinal.Maximum = 59;
            this.trackMinutosFinal.Name = "trackMinutosFinal";
            this.trackMinutosFinal.Size = new System.Drawing.Size(271, 45);
            this.trackMinutosFinal.TabIndex = 22;
            // 
            // tabPageConceptos
            // 
            this.tabPageConceptos.Controls.Add(this.textBox7);
            this.tabPageConceptos.Controls.Add(this.label13);
            this.tabPageConceptos.Controls.Add(this.textBox2);
            this.tabPageConceptos.Controls.Add(this.label12);
            this.tabPageConceptos.Controls.Add(this.comboBox1);
            this.tabPageConceptos.Controls.Add(this.textBox6);
            this.tabPageConceptos.Controls.Add(this.label11);
            this.tabPageConceptos.Controls.Add(this.textBox5);
            this.tabPageConceptos.Controls.Add(this.label10);
            this.tabPageConceptos.Controls.Add(this.textBox4);
            this.tabPageConceptos.Controls.Add(this.label9);
            this.tabPageConceptos.Controls.Add(this.textBox3);
            this.tabPageConceptos.Controls.Add(this.label8);
            this.tabPageConceptos.Controls.Add(this.label7);
            this.tabPageConceptos.Controls.Add(this.textBox1);
            this.tabPageConceptos.Controls.Add(this.label6);
            this.tabPageConceptos.Controls.Add(this.button2);
            this.tabPageConceptos.Controls.Add(this.textClaveViaje);
            this.tabPageConceptos.Controls.Add(this.dataGridView1);
            this.tabPageConceptos.Location = new System.Drawing.Point(4, 25);
            this.tabPageConceptos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageConceptos.Name = "tabPageConceptos";
            this.tabPageConceptos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageConceptos.Size = new System.Drawing.Size(888, 446);
            this.tabPageConceptos.TabIndex = 1;
            this.tabPageConceptos.Text = "Conceptos";
            this.tabPageConceptos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(509, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 28);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textClaveViaje
            // 
            this.textClaveViaje.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClaveViaje.ForeColor = System.Drawing.Color.DarkGray;
            this.textClaveViaje.Location = new System.Drawing.Point(128, 15);
            this.textClaveViaje.Name = "textClaveViaje";
            this.textClaveViaje.Size = new System.Drawing.Size(381, 26);
            this.textClaveViaje.TabIndex = 15;
            this.textClaveViaje.Text = "Ingrese el número de viaje";
            this.textClaveViaje.Click += new System.EventHandler(this.textClaveViaje_Click);
            this.textClaveViaje.Leave += new System.EventHandler(this.textClaveViaje_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageOtrosDatos
            // 
            this.tabPageOtrosDatos.Location = new System.Drawing.Point(4, 25);
            this.tabPageOtrosDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageOtrosDatos.Name = "tabPageOtrosDatos";
            this.tabPageOtrosDatos.Size = new System.Drawing.Size(888, 446);
            this.tabPageOtrosDatos.TabIndex = 2;
            this.tabPageOtrosDatos.Text = "Otros Datos";
            this.tabPageOtrosDatos.UseVisualStyleBackColor = true;
            // 
            // btnPrevius
            // 
            this.btnPrevius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnPrevius.FlatAppearance.BorderSize = 0;
            this.btnPrevius.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnPrevius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevius.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrevius.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevius.Image")));
            this.btnPrevius.Location = new System.Drawing.Point(631, 6);
            this.btnPrevius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevius.Name = "btnPrevius";
            this.btnPrevius.Size = new System.Drawing.Size(119, 41);
            this.btnPrevius.TabIndex = 14;
            this.btnPrevius.Text = "Anterior";
            this.btnPrevius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevius.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevius.UseVisualStyleBackColor = false;
            this.btnPrevius.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.Location = new System.Drawing.Point(756, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 41);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Siguiente ";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 572);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnPrevius);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Location = new System.Drawing.Point(16, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 55);
            this.panel3.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 26);
            this.textBox1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Clave Prod/Serv";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(128, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 26);
            this.textBox3.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(672, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 26);
            this.textBox4.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Valor Unitario";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(128, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(210, 26);
            this.textBox5.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Clave Unidad";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(672, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 26);
            this.textBox6.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(607, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Importe";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "78101802 - Servicios transporte de carga por carretera (en camión) a nivel region" +
                "al y nacional"});
            this.comboBox1.Location = new System.Drawing.Point(128, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(411, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(672, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 26);
            this.textBox2.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(601, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Iva (16%)";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(672, 105);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(210, 26);
            this.textBox7.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(563, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Retención (4%)";
            // 
            // FormAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAgregarFactura";
            this.Text = "Agregar Factura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageReceptor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelFechaFinal.ResumeLayout(false);
            this.panelFechaFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorasFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMinutosFinal)).EndInit();
            this.tabPageConceptos.ResumeLayout(false);
            this.tabPageConceptos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConceptos;
        private System.Windows.Forms.TabPage tabPageOtrosDatos;
        private System.Windows.Forms.TabPage tabPageReceptor;
        private System.Windows.Forms.Panel panelFechaFinal;
        private System.Windows.Forms.Button btnCancelarFechaFinal;
        private System.Windows.Forms.Button btnFechaHoyFinal;
        private System.Windows.Forms.Button btnAceptarFechaFinal;
        private System.Windows.Forms.MonthCalendar calendarFinalSci;
        private System.Windows.Forms.TrackBar trackHorasFinal;
        private System.Windows.Forms.TrackBar trackMinutosFinal;
        private System.Windows.Forms.Button btnPrevius;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRfc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Button btnBuscarClienteRFC;
        private System.Windows.Forms.Button btnCargarClientes;
        private System.Windows.Forms.ComboBox comboUsoDeCFDI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textClaveViaje;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
    }
}