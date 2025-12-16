using System;
using System.Drawing;
using System.Windows.Forms;

namespace Borrador
{
    public partial class MainForm : Form
    {
        private Button currentActiveButton;
        private bool menuExpanded = true;
        private int menuExpandWidth = 250;
        private int menuCollapseWidth = 60;

        public MainForm()
        {
            InitializeComponent();
            SetupSideMenuButtons();
            //no se

            this.Text = "Sistema de Gestión Clínica";
            this.Size = new Size(1200, 900);
            this.MinimumSize = new Size(1250, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlSideMenu.Width = menuExpandWidth;
            btnToggleMenu.Click += BtnToggleMenu_Click;

            // Cargar módulo por defecto
            if (pnlSideMenu.Controls.ContainsKey("btnPacientes"))
            {
                Button defaultButton = (Button)pnlSideMenu.Controls["btnPacientes"];
                ActivateButton(defaultButton);
                LoadUserControl((Type)defaultButton.Tag);
            }
        }


        private void SetupSideMenuButtons()
        {
            // Configurar colores del menú lateral
            pnlSideMenu.BackColor = Color.FromArgb(30, 41, 59);

            foreach (Control control in pnlSideMenu.Controls)
            {
                if (control is Button button && button.Name != "btnToggleMenu")
                {
                    button.Click += SideMenuButton_Click;

                    // Estilo moderno para los botones
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.FromArgb(203, 213, 225);
                    button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    button.TextAlign = ContentAlignment.MiddleLeft;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(20, 0, 0, 0);
                    button.Cursor = Cursors.Hand;

                    // Agregar efecto hover
                    button.MouseEnter += (s, e) =>
                    {
                        if (button != currentActiveButton)
                            button.BackColor = Color.FromArgb(51, 65, 85);
                    };
                    button.MouseLeave += (s, e) =>
                    {
                        if (button != currentActiveButton)
                            button.BackColor = Color.Transparent;
                    };

                    // Asignar módulos
                    switch (button.Name)
                    {
                        case "btnPacientes":
                            button.Tag = typeof(Modulo1);
                            button.Text = "  👥 Gestión de Pacientes";
                            break;
                        case "btnAgenda":
                            button.Tag = typeof(Modulo2);
                            button.Text = "  📅 Agenda de Citas";
                            break;
                        case "btnConsultasMedicas":
                            button.Tag = typeof(Modulo3);
                            button.Text = "  🩺 Consultas Médicas";
                            break;
                        case "btnEnfermeria":
                            button.Tag = typeof(Modulo4);
                            button.Text = "  💉 Enfermería";
                            break;
                        case "btnLaboratorio":
                            button.Tag = typeof(Modulo5);
                            button.Text = "  🔬 Laboratorio Clínico";
                            break;
                        case "btnImagenologia":
                            button.Tag = typeof(Modulo6);
                            button.Text = "  🏥 Imagenología";
                            break;
                        case "btnFarmacia":
                            button.Tag = typeof(Modulo7);
                            button.Text = "  💊 Farmacia";
                            break;
                        case "btnCirugias":
                            button.Tag = typeof(Modulo8);
                            button.Text = "  🏥 Hospitalización";
                            break;
                        case "btnHospitalizacion":
                            button.Tag = typeof(Modulo9);
                            button.Text = "  🚑 Urgencias";
                            break;
                        case "btnUrgencias":
                            button.Tag = typeof(Modulo10);
                            button.Text = "  ✂️ Cirugías";
                            break;
                        case "btnAdministrativo":
                            button.Tag = typeof(Modulo11);
                            button.Text = "  🏛️ Administrativo";
                            break;
                        default:
                            button.Tag = null;
                            break;
                    }
                }
            }

            // Configurar logo
            lblClinicManager.Text = "CLINIC MGR";
            lblClinicManager.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblClinicManager.ForeColor = Color.White;

            if (pbLogo != null)
            {
                try
                {
                    pbLogo.Image = Properties.Resources.logo_farm;
                }
                catch
                {
                    // Si no hay logo, simplemente no mostrarlo
                }
            }
        }

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Tag is Type userControlType)
            {
                ActivateButton(clickedButton);
                LoadUserControl(userControlType);
                UpdateBreadcrumb(clickedButton.Text);
            }
        }

        private void UpdateBreadcrumb(string moduleName)
        {
            // Actualizar breadcrumb en el top bar
            if (this.Controls.ContainsKey("pnlTopBar"))
            {
                Panel pnlTopBar = (Panel)this.Controls["pnlTopBar"];
                if (pnlTopBar.Controls.ContainsKey("lblBreadcrumb"))
                {
                    Label lblBreadcrumb = (Label)pnlTopBar.Controls["lblBreadcrumb"];
                    lblBreadcrumb.Text = $"Sistema Clínico / {moduleName.Trim()}";
                }
            }
        }

        private void ActivateButton(Button senderButton)
        {
            if (senderButton != null)
            {
                if (currentActiveButton != null && currentActiveButton != senderButton)
                {
                    DisableButton(currentActiveButton);
                }

                currentActiveButton = senderButton;
                currentActiveButton.BackColor = Color.FromArgb(59, 130, 246);
                currentActiveButton.ForeColor = Color.White;
                currentActiveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void DisableButton(Button buttonToDisable)
        {
            if (buttonToDisable != null)
            {
                buttonToDisable.BackColor = Color.Transparent;
                buttonToDisable.ForeColor = Color.FromArgb(203, 213, 225);
                buttonToDisable.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }
        }

        private void LoadUserControl(Type userControlType)
        {
            if (userControlType == null) return;

            try
            {
                pnlContent.Controls.Clear();
                UserControl newUserControl = (UserControl)Activator.CreateInstance(userControlType);
                newUserControl.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(newUserControl);
                newUserControl.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el módulo: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnToggleMenu_Click(object sender, EventArgs e)
        {
            tmrMenu.Start();
        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                pnlSideMenu.Width -= 10;
                if (pnlSideMenu.Width <= menuCollapseWidth)
                {
                    pnlSideMenu.Width = menuCollapseWidth;
                    tmrMenu.Stop();
                    menuExpanded = false;
                    ToggleMenuText(false);
                }
            }
            else
            {
                pnlSideMenu.Width += 10;
                if (pnlSideMenu.Width >= menuExpandWidth)
                {
                    pnlSideMenu.Width = menuExpandWidth;
                    tmrMenu.Stop();
                    menuExpanded = true;
                    ToggleMenuText(true);
                }
            }
        }

        private void ToggleMenuText(bool showText)
        {
            if (pnlLogo != null)
            {
                if (showText)
                {
                    lblClinicManager.Text = "CLINIC MGR";
                    lblClinicManager.Visible = true;
                    pbLogo.Visible = true;
                    lblClinicManager.Location = new Point(62, 38);
                    pbLogo.Location = new Point(12, 28);
                    btnToggleMenu.Location = new Point(pnlLogo.Width - btnToggleMenu.Width - 10, btnToggleMenu.Location.Y);
                }
                else
                {
                    lblClinicManager.Visible = false;
                    pbLogo.Visible = false;
                    btnToggleMenu.Location = new Point(pnlLogo.Width - btnToggleMenu.Width - 10, btnToggleMenu.Location.Y);
                }
            }

            foreach (Control control in pnlSideMenu.Controls)
            {
                if (control is Button button && button.Tag is Type)
                {
                    if (showText)
                    {
                        // Restaurar texto según el botón
                        switch (button.Name)
                        {
                            case "btnPacientes":
                                button.Text = "  👥 Gestión de Pacientes";
                                break;
                            case "btnAgenda":
                                button.Text = "  📅 Agenda de Citas";
                                break;
                            case "btnConsultasMedicas":
                                button.Text = "  🩺 Consultas Médicas";
                                break;
                            case "btnEnfermeria":
                                button.Text = "  💉 Enfermería";
                                break;
                            case "btnLaboratorio":
                                button.Text = "  🔬 Laboratorio Clínico";
                                break;
                            case "btnImagenologia":
                                button.Text = "  🏥 Imagenología";
                                break;
                            case "btnFarmacia":
                                button.Text = "  💊 Farmacia";
                                break;
                            case "btnCirugias":
                                button.Text = "  🏥 Hospitalización";
                                break;
                            case "btnHospitalizacion":
                                button.Text = "  🚑 Urgencias";
                                break;
                            case "btnUrgencias":
                                button.Text = "  ✂️ Cirugías";
                                break;
                            case "btnAdministrativo":
                                button.Text = "  🏛️ Administrativo";
                                break;
                        }
                        button.TextAlign = ContentAlignment.MiddleLeft;
                        button.Padding = new Padding(20, 0, 0, 0);
                    }
                    else
                    {
                        button.Text = "";
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Padding = new Padding(0);
                    }

                    button.Invalidate();
                    button.Update();
                }
            }
        }

        private void btnToggleMenu_Click_1(object sender, EventArgs e)
        {
            // Este método lo llama el designer
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            // Este método lo llama el designer
        }
    }
}