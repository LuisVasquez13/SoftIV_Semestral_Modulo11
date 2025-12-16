namespace Borrador
{
    partial class Modulo8
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cBMedicoR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttTasladar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttAlta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bttAdmitir = new System.Windows.Forms.Button();
            this.txtbDiagnostico = new System.Windows.Forms.TextBox();
            this.dateTimer = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBMotivo = new System.Windows.Forms.TextBox();
            this.txtBIdHospitalizacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBPaciente = new System.Windows.Forms.ComboBox();
            this.cBCama = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cBSala = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableListaC = new System.Windows.Forms.DataGridView();
            this.btnDetalles_camas = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxSala = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxFiltradoC = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableListaC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1282, 915);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cBMedicoR);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bttTasladar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bttAlta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bttAdmitir);
            this.tabPage1.Controls.Add(this.txtbDiagnostico);
            this.tabPage1.Controls.Add(this.dateTimer);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtBMotivo);
            this.tabPage1.Controls.Add(this.txtBIdHospitalizacion);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cBPaciente);
            this.tabPage1.Controls.Add(this.cBCama);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.cBSala);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1274, 879);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admisión";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cBMedicoR
            // 
            this.cBMedicoR.BackColor = System.Drawing.Color.White;
            this.cBMedicoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMedicoR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBMedicoR.FormattingEnabled = true;
            this.cBMedicoR.Location = new System.Drawing.Point(1032, 17);
            this.cBMedicoR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBMedicoR.Name = "cBMedicoR";
            this.cBMedicoR.Size = new System.Drawing.Size(221, 31);
            this.cBMedicoR.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Hospitalizacion:";
            // 
            // bttTasladar
            // 
            this.bttTasladar.BackColor = System.Drawing.Color.Goldenrod;
            this.bttTasladar.FlatAppearance.BorderSize = 0;
            this.bttTasladar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttTasladar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bttTasladar.ForeColor = System.Drawing.Color.White;
            this.bttTasladar.Location = new System.Drawing.Point(951, 812);
            this.bttTasladar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttTasladar.Name = "bttTasladar";
            this.bttTasladar.Size = new System.Drawing.Size(146, 47);
            this.bttTasladar.TabIndex = 24;
            this.bttTasladar.Text = "Trasladar";
            this.bttTasladar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente:";
            // 
            // bttAlta
            // 
            this.bttAlta.BackColor = System.Drawing.Color.Green;
            this.bttAlta.FlatAppearance.BorderSize = 0;
            this.bttAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAlta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bttAlta.ForeColor = System.Drawing.Color.White;
            this.bttAlta.Location = new System.Drawing.Point(1112, 812);
            this.bttAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttAlta.Name = "bttAlta";
            this.bttAlta.Size = new System.Drawing.Size(141, 47);
            this.bttAlta.TabIndex = 23;
            this.bttAlta.Text = "Dar Alta";
            this.bttAlta.UseVisualStyleBackColor = false;
            this.bttAlta.Click += new System.EventHandler(this.bttAlta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diagnostico de Ingreso:";
            // 
            // bttAdmitir
            // 
            this.bttAdmitir.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttAdmitir.FlatAppearance.BorderSize = 0;
            this.bttAdmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdmitir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bttAdmitir.ForeColor = System.Drawing.Color.White;
            this.bttAdmitir.Location = new System.Drawing.Point(802, 812);
            this.bttAdmitir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttAdmitir.Name = "bttAdmitir";
            this.bttAdmitir.Size = new System.Drawing.Size(135, 47);
            this.bttAdmitir.TabIndex = 22;
            this.bttAdmitir.Text = "Admitir";
            this.bttAdmitir.UseVisualStyleBackColor = false;
            // 
            // txtbDiagnostico
            // 
            this.txtbDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbDiagnostico.Location = new System.Drawing.Point(13, 217);
            this.txtbDiagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbDiagnostico.MaxLength = 300;
            this.txtbDiagnostico.Multiline = true;
            this.txtbDiagnostico.Name = "txtbDiagnostico";
            this.txtbDiagnostico.Size = new System.Drawing.Size(1240, 176);
            this.txtbDiagnostico.TabIndex = 3;
            // 
            // dateTimer
            // 
            this.dateTimer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimer.Location = new System.Drawing.Point(857, 115);
            this.dateTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimer.Name = "dateTimer";
            this.dateTimer.Size = new System.Drawing.Size(329, 30);
            this.dateTimer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motivo de hospitalizacion:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(853, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha/Hora de Ingreso";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtBMotivo
            // 
            this.txtBMotivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBMotivo.Location = new System.Drawing.Point(13, 456);
            this.txtBMotivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBMotivo.MaxLength = 300;
            this.txtBMotivo.Multiline = true;
            this.txtBMotivo.Name = "txtBMotivo";
            this.txtBMotivo.Size = new System.Drawing.Size(1240, 266);
            this.txtBMotivo.TabIndex = 6;
            // 
            // txtBIdHospitalizacion
            // 
            this.txtBIdHospitalizacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBIdHospitalizacion.Location = new System.Drawing.Point(160, 14);
            this.txtBIdHospitalizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBIdHospitalizacion.MaxLength = 40;
            this.txtBIdHospitalizacion.Name = "txtBIdHospitalizacion";
            this.txtBIdHospitalizacion.Size = new System.Drawing.Size(193, 30);
            this.txtBIdHospitalizacion.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(855, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Medico responsable:";
            // 
            // cBPaciente
            // 
            this.cBPaciente.BackColor = System.Drawing.Color.White;
            this.cBPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBPaciente.FormattingEnabled = true;
            this.cBPaciente.Location = new System.Drawing.Point(166, 89);
            this.cBPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBPaciente.Name = "cBPaciente";
            this.cBPaciente.Size = new System.Drawing.Size(193, 31);
            this.cBPaciente.TabIndex = 8;
            // 
            // cBCama
            // 
            this.cBCama.BackColor = System.Drawing.Color.White;
            this.cBCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBCama.FormattingEnabled = true;
            this.cBCama.Location = new System.Drawing.Point(484, 89);
            this.cBCama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBCama.Name = "cBCama";
            this.cBCama.Size = new System.Drawing.Size(246, 31);
            this.cBCama.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 766);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de regimen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cama:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Privada",
            "Seguro",
            "Estado"});
            this.comboBox2.Location = new System.Drawing.Point(164, 763);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 31);
            this.comboBox2.TabIndex = 10;
            // 
            // cBSala
            // 
            this.cBSala.BackColor = System.Drawing.Color.White;
            this.cBSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBSala.FormattingEnabled = true;
            this.cBSala.Location = new System.Drawing.Point(478, 16);
            this.cBSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSala.Name = "cBSala";
            this.cBSala.Size = new System.Drawing.Size(246, 31);
            this.cBSala.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 766);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sala:";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Hospitalizado",
            "Alta",
            "Referido"});
            this.comboBox3.Location = new System.Drawing.Point(425, 763);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(321, 31);
            this.comboBox3.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1274, 879);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Camas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableListaC);
            this.panel2.Controls.Add(this.btnDetalles_camas);
            this.panel2.Controls.Add(this.btnRefrescar);
            this.panel2.Location = new System.Drawing.Point(47, 141);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 717);
            this.panel2.TabIndex = 9;
            // 
            // tableListaC
            // 
            this.tableListaC.AllowUserToAddRows = false;
            this.tableListaC.AllowUserToDeleteRows = false;
            this.tableListaC.BackgroundColor = System.Drawing.Color.White;
            this.tableListaC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(46)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableListaC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableListaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableListaC.EnableHeadersVisualStyles = false;
            this.tableListaC.Location = new System.Drawing.Point(15, 19);
            this.tableListaC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableListaC.Name = "tableListaC";
            this.tableListaC.ReadOnly = true;
            this.tableListaC.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tableListaC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableListaC.RowTemplate.Height = 28;
            this.tableListaC.Size = new System.Drawing.Size(1173, 630);
            this.tableListaC.TabIndex = 5;
            // 
            // btnDetalles_camas
            // 
            this.btnDetalles_camas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(46)))), ((int)(((byte)(89)))));
            this.btnDetalles_camas.FlatAppearance.BorderSize = 0;
            this.btnDetalles_camas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles_camas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetalles_camas.ForeColor = System.Drawing.Color.White;
            this.btnDetalles_camas.Location = new System.Drawing.Point(944, 662);
            this.btnDetalles_camas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalles_camas.Name = "btnDetalles_camas";
            this.btnDetalles_camas.Size = new System.Drawing.Size(244, 34);
            this.btnDetalles_camas.TabIndex = 7;
            this.btnDetalles_camas.Text = "Ver detalles de cama";
            this.btnDetalles_camas.UseVisualStyleBackColor = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Green;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(807, 662);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(120, 34);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cboxSala);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cboxFiltradoC);
            this.panel1.Location = new System.Drawing.Point(47, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 80);
            this.panel1.TabIndex = 8;
            // 
            // cboxSala
            // 
            this.cboxSala.AutoCompleteCustomSource.AddRange(new string[] {
            "A1",
            "A2",
            "A3",
            "S3"});
            this.cboxSala.BackColor = System.Drawing.Color.White;
            this.cboxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxSala.FormattingEnabled = true;
            this.cboxSala.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4"});
            this.cboxSala.Location = new System.Drawing.Point(57, 11);
            this.cboxSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSala.Name = "cboxSala";
            this.cboxSala.Size = new System.Drawing.Size(351, 31);
            this.cboxSala.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sala:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Filtro por estado:";
            // 
            // cboxFiltradoC
            // 
            this.cboxFiltradoC.BackColor = System.Drawing.Color.White;
            this.cboxFiltradoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFiltradoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxFiltradoC.FormattingEnabled = true;
            this.cboxFiltradoC.Items.AddRange(new object[] {
            "Todas",
            "Libres",
            "Ocupadas",
            "Reservadas"});
            this.cboxFiltradoC.Location = new System.Drawing.Point(157, 45);
            this.cboxFiltradoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxFiltradoC.Name = "cboxFiltradoC";
            this.cboxFiltradoC.Size = new System.Drawing.Size(251, 31);
            this.cboxFiltradoC.TabIndex = 3;
            // 
            // Modulo8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Modulo8";
            this.Size = new System.Drawing.Size(1323, 946);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableListaC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cBMedicoR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttTasladar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttAdmitir;
        private System.Windows.Forms.TextBox txtbDiagnostico;
        private System.Windows.Forms.DateTimePicker dateTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBMotivo;
        private System.Windows.Forms.TextBox txtBIdHospitalizacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBPaciente;
        private System.Windows.Forms.ComboBox cBCama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cBSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableListaC;
        private System.Windows.Forms.Button btnDetalles_camas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxSala;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxFiltradoC;
    }
}