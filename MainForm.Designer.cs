namespace Borrador
{
    partial class MainForm // O Form1 si no lo renombraste
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
            this.components = new System.ComponentModel.Container();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnUrgencias = new System.Windows.Forms.Button();
            this.btnHospitalizacion = new System.Windows.Forms.Button();
            this.btnCirugias = new System.Windows.Forms.Button();
            this.btnFarmacia = new System.Windows.Forms.Button();
            this.btnImagenologia = new System.Windows.Forms.Button();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.btnEnfermeria = new System.Windows.Forms.Button();
            this.btnConsultasMedicas = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblClinicManager = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tmrMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlSideMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; // Esto puede ser None también
            this.pnlSideMenu.AutoSize = false; // Asegúrate de que AutoSize también sea false
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.pnlSideMenu.Controls.Add(this.btnAdministrativo);
            this.pnlSideMenu.Controls.Add(this.btnUrgencias);
            this.pnlSideMenu.Controls.Add(this.btnHospitalizacion);
            this.pnlSideMenu.Controls.Add(this.btnCirugias);
            this.pnlSideMenu.Controls.Add(this.btnFarmacia);
            this.pnlSideMenu.Controls.Add(this.btnImagenologia);
            this.pnlSideMenu.Controls.Add(this.btnLaboratorio);
            this.pnlSideMenu.Controls.Add(this.btnEnfermeria);
            this.pnlSideMenu.Controls.Add(this.btnConsultasMedicas);
            this.pnlSideMenu.Controls.Add(this.btnAgenda);
            this.pnlSideMenu.Controls.Add(this.btnPacientes);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(230, 869);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrativo.FlatAppearance.BorderSize = 0;
            this.btnAdministrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrativo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrativo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdministrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrativo.Location = new System.Drawing.Point(0, 600);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdministrativo.Size = new System.Drawing.Size(421, 50);
            this.btnAdministrativo.TabIndex = 10;
            this.btnAdministrativo.Text = "  Administrativo y Financiero 11";
            this.btnAdministrativo.UseVisualStyleBackColor = false;
            // 
            // btnUrgencias
            // 
            this.btnUrgencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrgencias.FlatAppearance.BorderSize = 0;
            this.btnUrgencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgencias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgencias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUrgencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrgencias.Location = new System.Drawing.Point(0, 550);
            this.btnUrgencias.Name = "btnUrgencias";
            this.btnUrgencias.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUrgencias.Size = new System.Drawing.Size(421, 50);
            this.btnUrgencias.TabIndex = 9;
            this.btnUrgencias.Text = "  Cirugías y Quirófano 10";
            this.btnUrgencias.UseVisualStyleBackColor = false;
            // 
            // btnHospitalizacion
            // 
            this.btnHospitalizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospitalizacion.FlatAppearance.BorderSize = 0;
            this.btnHospitalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospitalizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitalizacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHospitalizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospitalizacion.Location = new System.Drawing.Point(0, 500);
            this.btnHospitalizacion.Name = "btnHospitalizacion";
            this.btnHospitalizacion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHospitalizacion.Size = new System.Drawing.Size(421, 50);
            this.btnHospitalizacion.TabIndex = 8;
            this.btnHospitalizacion.Text = "  Urgencias 9";
            this.btnHospitalizacion.UseVisualStyleBackColor = false;
            // 
            // btnCirugias
            // 
            this.btnCirugias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCirugias.FlatAppearance.BorderSize = 0;
            this.btnCirugias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirugias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirugias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCirugias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirugias.Location = new System.Drawing.Point(0, 450);
            this.btnCirugias.Name = "btnCirugias";
            this.btnCirugias.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCirugias.Size = new System.Drawing.Size(421, 50);
            this.btnCirugias.TabIndex = 7;
            this.btnCirugias.Text = "  Hospitalización 8";
            this.btnCirugias.UseVisualStyleBackColor = false;
            // 
            // btnFarmacia
            // 
            this.btnFarmacia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFarmacia.FlatAppearance.BorderSize = 0;
            this.btnFarmacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarmacia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmacia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFarmacia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFarmacia.Location = new System.Drawing.Point(0, 400);
            this.btnFarmacia.Name = "btnFarmacia";
            this.btnFarmacia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFarmacia.Size = new System.Drawing.Size(421, 50);
            this.btnFarmacia.TabIndex = 6;
            this.btnFarmacia.Text = "  Farmacia 7";
            this.btnFarmacia.UseVisualStyleBackColor = false;
            // 
            // btnImagenologia
            // 
            this.btnImagenologia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImagenologia.FlatAppearance.BorderSize = 0;
            this.btnImagenologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagenologia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenologia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImagenologia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagenologia.Location = new System.Drawing.Point(0, 350);
            this.btnImagenologia.Name = "btnImagenologia";
            this.btnImagenologia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnImagenologia.Size = new System.Drawing.Size(421, 50);
            this.btnImagenologia.TabIndex = 5;
            this.btnImagenologia.Text = "  Imagenología 6";
            this.btnImagenologia.UseVisualStyleBackColor = false;
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaboratorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaboratorio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLaboratorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaboratorio.Location = new System.Drawing.Point(0, 300);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLaboratorio.Size = new System.Drawing.Size(421, 50);
            this.btnLaboratorio.TabIndex = 4;
            this.btnLaboratorio.Text = "  Laboratorio Clínico 5";
            this.btnLaboratorio.UseVisualStyleBackColor = false;
            // 
            // btnEnfermeria
            // 
            this.btnEnfermeria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnfermeria.FlatAppearance.BorderSize = 0;
            this.btnEnfermeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnfermeria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnfermeria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnfermeria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnfermeria.Location = new System.Drawing.Point(0, 250);
            this.btnEnfermeria.Name = "btnEnfermeria";
            this.btnEnfermeria.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEnfermeria.Size = new System.Drawing.Size(421, 50);
            this.btnEnfermeria.TabIndex = 3;
            this.btnEnfermeria.Text = "  Enfermería 4";
            this.btnEnfermeria.UseVisualStyleBackColor = false;
            // 
            // btnConsultasMedicas
            // 
            this.btnConsultasMedicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultasMedicas.FlatAppearance.BorderSize = 0;
            this.btnConsultasMedicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasMedicas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasMedicas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsultasMedicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultasMedicas.Location = new System.Drawing.Point(0, 200);
            this.btnConsultasMedicas.Name = "btnConsultasMedicas";
            this.btnConsultasMedicas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConsultasMedicas.Size = new System.Drawing.Size(421, 50);
            this.btnConsultasMedicas.TabIndex = 2;
            this.btnConsultasMedicas.Text = "  Consultas Médicas 3";
            this.btnConsultasMedicas.UseVisualStyleBackColor = false;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(0, 150);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgenda.Size = new System.Drawing.Size(421, 50);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "  Agenda y Citas 2";
            this.btnAgenda.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 100);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPacientes.Size = new System.Drawing.Size(421, 50);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "  Gestión de Pacientes 1";
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblClinicManager);
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Controls.Add(this.btnToggleMenu);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(421, 100);
            this.pnlLogo.TabIndex = 11;
            // 
            // lblClinicManager
            // 
            this.lblClinicManager.AutoSize = true;
            this.lblClinicManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicManager.ForeColor = System.Drawing.Color.White;
            this.lblClinicManager.Location = new System.Drawing.Point(94, 44);
            this.lblClinicManager.Name = "lblClinicManager";
            this.lblClinicManager.Size = new System.Drawing.Size(126, 28);
            this.lblClinicManager.TabIndex = 1;
            this.lblClinicManager.Text = "CLINIC MGR";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Borrador.Properties.Resources.logo_farm;
            this.pbLogo.Location = new System.Drawing.Point(16, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(44, 44);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleMenu.FlatAppearance.BorderSize = 0;
            this.btnToggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMenu.Image = global::Borrador.Properties.Resources.icon_hamburguesa;
            this.btnToggleMenu.Location = new System.Drawing.Point(355, 28);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(59, 59);
            this.btnToggleMenu.TabIndex = 2;
            this.btnToggleMenu.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(421, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1168, 869);
            this.pnlContent.TabIndex = 1;
            // 
            // tmrMenu
            // 
            this.tmrMenu.Interval = 10;
            this.tmrMenu.Tick += new System.EventHandler(this.tmrMenu_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 869);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "MainForm";
            this.Text = "Clinic Manager System";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlContent;

        // Declaraciones de los botones del menú (añadidas aquí)
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnAdministrativo;
        private System.Windows.Forms.Button btnUrgencias;
        private System.Windows.Forms.Button btnHospitalizacion;
        private System.Windows.Forms.Button btnCirugias;
        private System.Windows.Forms.Button btnFarmacia;
        private System.Windows.Forms.Button btnImagenologia;
        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.Button btnEnfermeria;
        private System.Windows.Forms.Button btnConsultasMedicas;
        private System.Windows.Forms.Button btnAgenda;

        private System.Windows.Forms.Panel pnlLogo; // Declaración del panel del logo
        private System.Windows.Forms.Label lblClinicManager; // Declaración del label del título
        private System.Windows.Forms.PictureBox pbLogo; // Declaración del PictureBox del logo
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Timer tmrMenu;
    }
}