namespace SCI.INTERFAZ.UI
{
    partial class FormAgregarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarViaje));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDateFinCliente = new System.Windows.Forms.TextBox();
            this.textDateInicioCliente = new System.Windows.Forms.TextBox();
            this.textDateFinSci = new System.Windows.Forms.TextBox();
            this.textDateInicioSci = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CalendarCliente = new System.Windows.Forms.MonthCalendar();
            this.calendarSci = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboOperadores = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboRutas = new System.Windows.Forms.ComboBox();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.textClaveViajeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGenerales = new System.Windows.Forms.TabPage();
            this.tabPageGastos = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboTipoGastos = new System.Windows.Forms.ComboBox();
            this.textConceptoGasto = new System.Windows.Forms.TextBox();
            this.textMontoGasto = new System.Windows.Forms.TextBox();
            this.textRutaXml = new System.Windows.Forms.TextBox();
            this.dateTimeFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.btnExaminarPdf = new System.Windows.Forms.Button();
            this.textRutaPdf = new System.Windows.Forms.TextBox();
            this.btnExaminarXml = new System.Windows.Forms.Button();
            this.tabPageCortes = new System.Windows.Forms.TabPage();
            this.labelTotalDeGastos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageGenerales.SuspendLayout();
            this.tabPageGastos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(367, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 260);
            this.panel2.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fechas Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Fechas Inicial";
            // 
            // textDateFinCliente
            // 
            this.textDateFinCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateFinCliente.Location = new System.Drawing.Point(380, 282);
            this.textDateFinCliente.Name = "textDateFinCliente";
            this.textDateFinCliente.Size = new System.Drawing.Size(248, 26);
            this.textDateFinCliente.TabIndex = 20;
            // 
            // textDateInicioCliente
            // 
            this.textDateInicioCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateInicioCliente.Location = new System.Drawing.Point(380, 250);
            this.textDateInicioCliente.Name = "textDateInicioCliente";
            this.textDateInicioCliente.Size = new System.Drawing.Size(248, 26);
            this.textDateInicioCliente.TabIndex = 19;
            // 
            // textDateFinSci
            // 
            this.textDateFinSci.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateFinSci.Location = new System.Drawing.Point(107, 282);
            this.textDateFinSci.Name = "textDateFinSci";
            this.textDateFinSci.Size = new System.Drawing.Size(248, 26);
            this.textDateFinSci.TabIndex = 18;
            // 
            // textDateInicioSci
            // 
            this.textDateInicioSci.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateInicioSci.Location = new System.Drawing.Point(107, 250);
            this.textDateInicioSci.Name = "textDateInicioSci";
            this.textDateInicioSci.Size = new System.Drawing.Size(248, 26);
            this.textDateInicioSci.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(440, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Fechas del Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(200, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Fechas SCI";
            // 
            // CalendarCliente
            // 
            this.CalendarCliente.Location = new System.Drawing.Point(380, 76);
            this.CalendarCliente.MaxSelectionCount = 30;
            this.CalendarCliente.Name = "CalendarCliente";
            this.CalendarCliente.TabIndex = 13;
            this.CalendarCliente.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarCliente_DateSelected);
            // 
            // calendarSci
            // 
            this.calendarSci.Location = new System.Drawing.Point(107, 76);
            this.calendarSci.MaxSelectionCount = 30;
            this.calendarSci.Name = "calendarSci";
            this.calendarSci.TabIndex = 11;
            this.calendarSci.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarSci_DateSelected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.Enabled = false;
            this.comboStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(197, 465);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(431, 25);
            this.comboStatus.TabIndex = 9;
            this.comboStatus.SelectedValueChanged += new System.EventHandler(this.comboStatus_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccionar Operador";
            // 
            // comboOperadores
            // 
            this.comboOperadores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOperadores.FormattingEnabled = true;
            this.comboOperadores.Location = new System.Drawing.Point(197, 434);
            this.comboOperadores.Name = "comboOperadores";
            this.comboOperadores.Size = new System.Drawing.Size(431, 25);
            this.comboOperadores.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seleccionar Cliente";
            // 
            // comboClientes
            // 
            this.comboClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(197, 403);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(431, 25);
            this.comboClientes.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccionar Ruta";
            // 
            // comboRutas
            // 
            this.comboRutas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRutas.FormattingEnabled = true;
            this.comboRutas.Location = new System.Drawing.Point(197, 372);
            this.comboRutas.Name = "comboRutas";
            this.comboRutas.Size = new System.Drawing.Size(431, 25);
            this.comboRutas.TabIndex = 6;
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarViaje.FlatAppearance.BorderSize = 0;
            this.btnAgregarViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAgregarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarViaje.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarViaje.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarViaje.Image")));
            this.btnAgregarViaje.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarViaje.Location = new System.Drawing.Point(498, 506);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(130, 33);
            this.btnAgregarViaje.TabIndex = 10;
            this.btnAgregarViaje.Text = "Agregar Viaje";
            this.btnAgregarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarViaje.UseVisualStyleBackColor = false;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // textClaveViajeCliente
            // 
            this.textClaveViajeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClaveViajeCliente.Location = new System.Drawing.Point(197, 340);
            this.textClaveViajeCliente.Name = "textClaveViajeCliente";
            this.textClaveViajeCliente.Size = new System.Drawing.Size(431, 26);
            this.textClaveViajeCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave Viaje Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.labelTotalDeGastos);
            this.groupBox2.Controls.Add(this.btnExaminarXml);
            this.groupBox2.Controls.Add(this.textRutaPdf);
            this.groupBox2.Controls.Add(this.btnExaminarPdf);
            this.groupBox2.Controls.Add(this.btnAgregarGasto);
            this.groupBox2.Controls.Add(this.dgvGastos);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimeFechaGasto);
            this.groupBox2.Controls.Add(this.textRutaXml);
            this.groupBox2.Controls.Add(this.textMontoGasto);
            this.groupBox2.Controls.Add(this.textConceptoGasto);
            this.groupBox2.Controls.Add(this.comboTipoGastos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 560);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo De Gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Archivo PDF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(181, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Archivo XML";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(219, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Fecha";
            // 
            // dgvGastos
            // 
            this.dgvGastos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(6, 272);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.Size = new System.Drawing.Size(633, 239);
            this.dgvGastos.TabIndex = 35;
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarGasto.FlatAppearance.BorderSize = 0;
            this.btnAgregarGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAgregarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGasto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGasto.Image")));
            this.btnAgregarGasto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarGasto.Location = new System.Drawing.Point(507, 185);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(130, 33);
            this.btnAgregarGasto.TabIndex = 25;
            this.btnAgregarGasto.Text = "Agregar Gasto";
            this.btnAgregarGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarGasto.UseVisualStyleBackColor = false;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGenerales);
            this.tabControl1.Controls.Add(this.tabPageGastos);
            this.tabControl1.Controls.Add(this.tabPageCortes);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 598);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPageGenerales
            // 
            this.tabPageGenerales.Controls.Add(this.groupBox3);
            this.tabPageGenerales.Location = new System.Drawing.Point(4, 25);
            this.tabPageGenerales.Name = "tabPageGenerales";
            this.tabPageGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerales.Size = new System.Drawing.Size(655, 569);
            this.tabPageGenerales.TabIndex = 0;
            this.tabPageGenerales.Text = "Datos Generales";
            this.tabPageGenerales.UseVisualStyleBackColor = true;
            // 
            // tabPageGastos
            // 
            this.tabPageGastos.Controls.Add(this.groupBox2);
            this.tabPageGastos.Location = new System.Drawing.Point(4, 25);
            this.tabPageGastos.Name = "tabPageGastos";
            this.tabPageGastos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGastos.Size = new System.Drawing.Size(655, 569);
            this.tabPageGastos.TabIndex = 1;
            this.tabPageGastos.Text = "Gastos";
            this.tabPageGastos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calendarSci);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textClaveViajeCliente);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.btnAgregarViaje);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboRutas);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textDateFinCliente);
            this.groupBox3.Controls.Add(this.comboClientes);
            this.groupBox3.Controls.Add(this.textDateInicioCliente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textDateFinSci);
            this.groupBox3.Controls.Add(this.comboOperadores);
            this.groupBox3.Controls.Add(this.textDateInicioSci);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboStatus);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CalendarCliente);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 554);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // comboTipoGastos
            // 
            this.comboTipoGastos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoGastos.FormattingEnabled = true;
            this.comboTipoGastos.Location = new System.Drawing.Point(272, 26);
            this.comboTipoGastos.Name = "comboTipoGastos";
            this.comboTipoGastos.Size = new System.Drawing.Size(366, 25);
            this.comboTipoGastos.TabIndex = 25;
            // 
            // textConceptoGasto
            // 
            this.textConceptoGasto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConceptoGasto.Location = new System.Drawing.Point(272, 57);
            this.textConceptoGasto.Name = "textConceptoGasto";
            this.textConceptoGasto.Size = new System.Drawing.Size(367, 26);
            this.textConceptoGasto.TabIndex = 25;
            // 
            // textMontoGasto
            // 
            this.textMontoGasto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMontoGasto.Location = new System.Drawing.Point(523, 88);
            this.textMontoGasto.Name = "textMontoGasto";
            this.textMontoGasto.Size = new System.Drawing.Size(114, 26);
            this.textMontoGasto.TabIndex = 26;
            // 
            // textRutaXml
            // 
            this.textRutaXml.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRutaXml.Location = new System.Drawing.Point(272, 153);
            this.textRutaXml.Name = "textRutaXml";
            this.textRutaXml.Size = new System.Drawing.Size(284, 26);
            this.textRutaXml.TabIndex = 28;
            // 
            // dateTimeFechaGasto
            // 
            this.dateTimeFechaGasto.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaGasto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaGasto.Location = new System.Drawing.Point(272, 92);
            this.dateTimeFechaGasto.Name = "dateTimeFechaGasto";
            this.dateTimeFechaGasto.Size = new System.Drawing.Size(178, 23);
            this.dateTimeFechaGasto.TabIndex = 29;
            // 
            // btnExaminarPdf
            // 
            this.btnExaminarPdf.Location = new System.Drawing.Point(562, 121);
            this.btnExaminarPdf.Name = "btnExaminarPdf";
            this.btnExaminarPdf.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarPdf.TabIndex = 36;
            this.btnExaminarPdf.Text = "Examinar...";
            this.btnExaminarPdf.UseVisualStyleBackColor = true;
            this.btnExaminarPdf.Click += new System.EventHandler(this.btnExaminarPdf_Click);
            // 
            // textRutaPdf
            // 
            this.textRutaPdf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRutaPdf.Location = new System.Drawing.Point(272, 121);
            this.textRutaPdf.Name = "textRutaPdf";
            this.textRutaPdf.Size = new System.Drawing.Size(284, 26);
            this.textRutaPdf.TabIndex = 37;
            // 
            // btnExaminarXml
            // 
            this.btnExaminarXml.Location = new System.Drawing.Point(562, 153);
            this.btnExaminarXml.Name = "btnExaminarXml";
            this.btnExaminarXml.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarXml.TabIndex = 38;
            this.btnExaminarXml.Text = "Examinar...";
            this.btnExaminarXml.UseVisualStyleBackColor = true;
            this.btnExaminarXml.Click += new System.EventHandler(this.btnExaminarXml_Click);
            // 
            // tabPageCortes
            // 
            this.tabPageCortes.Location = new System.Drawing.Point(4, 25);
            this.tabPageCortes.Name = "tabPageCortes";
            this.tabPageCortes.Size = new System.Drawing.Size(655, 569);
            this.tabPageCortes.TabIndex = 2;
            this.tabPageCortes.Text = "Cortes";
            this.tabPageCortes.UseVisualStyleBackColor = true;
            // 
            // labelTotalDeGastos
            // 
            this.labelTotalDeGastos.AutoSize = true;
            this.labelTotalDeGastos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeGastos.Location = new System.Drawing.Point(558, 514);
            this.labelTotalDeGastos.Name = "labelTotalDeGastos";
            this.labelTotalDeGastos.Size = new System.Drawing.Size(48, 23);
            this.labelTotalDeGastos.TabIndex = 39;
            this.labelTotalDeGastos.Text = "0.00";
            this.labelTotalDeGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(409, 520);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Total de Gastos";
            // 
            // FormAgregarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 596);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAgregarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar un nuevo viaje";
            this.Load += new System.EventHandler(this.FormAgregarViaje_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGenerales.ResumeLayout(false);
            this.tabPageGastos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.TextBox textClaveViajeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRutas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboOperadores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.MonthCalendar calendarSci;
        private System.Windows.Forms.MonthCalendar CalendarCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textDateFinCliente;
        private System.Windows.Forms.TextBox textDateInicioCliente;
        private System.Windows.Forms.TextBox textDateFinSci;
        private System.Windows.Forms.TextBox textDateInicioSci;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGenerales;
        private System.Windows.Forms.TabPage tabPageGastos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExaminarXml;
        private System.Windows.Forms.TextBox textRutaPdf;
        private System.Windows.Forms.Button btnExaminarPdf;
        private System.Windows.Forms.DateTimePicker dateTimeFechaGasto;
        private System.Windows.Forms.TextBox textRutaXml;
        private System.Windows.Forms.TextBox textMontoGasto;
        private System.Windows.Forms.TextBox textConceptoGasto;
        private System.Windows.Forms.ComboBox comboTipoGastos;
        private System.Windows.Forms.TabPage tabPageCortes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelTotalDeGastos;
    }
}