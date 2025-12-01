using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador
{
    public partial class MainForm : Form
    {
        private Button currentActiveButton;
        private bool menuExpanded = true; // Estado inicial: menú expandido
        private int menuExpandWidth = 230; // Ancho cuando el menú está expandido
        private int menuCollapseWidth = 60; // Ancho cuando el menú está colapsado (solo iconos)

        public MainForm()
        {
            InitializeComponent();
            SetupSideMenuButtons();

            this.Text = "Clinic Manager System";
            this.Size = new Size(1200, 800);
            this.MinimumSize = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Ajustar el ancho inicial del pnlSideMenu
            pnlSideMenu.Width = menuExpandWidth;

            // Asignar el evento Click al botón de hamburguesa
            btnToggleMenu.Click += BtnToggleMenu_Click;

            // Opcional: Cargar un UserControl por defecto al inicio (ej. Pacientes)
            if (pnlSideMenu.Controls.ContainsKey("btnPacientes"))
            {
                Button defaultButton = (Button)pnlSideMenu.Controls["btnPacientes"];
                ActivateButton(defaultButton);
                LoadUserControl((Type)defaultButton.Tag);
            }
        }

        private void SetupSideMenuButtons()
        {
            foreach (Control control in pnlSideMenu.Controls)
            {
                // Solo configuramos los botones de navegación, no el pnlLogo
                if (control is Button button && button.Name != "btnToggleMenu")
                {
                    button.Click += SideMenuButton_Click;

                    // Asigna el tipo de UserControl a la propiedad Tag de cada botón
                    switch (button.Name)
                    {
                        case "btnPacientes":
                            //Modulo 1
                            button.Tag = typeof(UCPacientesCRUD);
                           // button.Image = Properties.Resources.icon_pacientes; // Asegúrate de tener este recurso
                            break;
                        case "btnAgenda":
                            //Modulo 2
                            button.Tag = typeof(UCAgendaCitasMedico);
                           // button.Image = Properties.Resources.icon_agenda; // Asegúrate de tener este recurso
                            break;

                        case "btnConsultasMedicas":
                            //Modulo 3
                            button.Tag = typeof(UCConsultaMedica);
                            //button.Image = Properties.Resources.icon_consultas;
                            break;

                        case "btnEnfermeria":
                            //Modulo 4
                            button.Tag = typeof(UCHojaEnfermeria);
                            //button.Image = Properties.Resources.icon_enfermeria;
                            break;

                        case "btnLaboratorio":
                            //Modulo 5
                            button.Tag = typeof(UCOrdenLaboratorio);
                            //button.Image = Properties.Resources.icon_laboratorio;
                            break;

                        case "btnImagenologia":
                            //Modulo 6
                            button.Tag = typeof(UCEstudiosImagen);
                            //button.Image = Properties.Resources.icon_imagenologia;
                            break;

                        case "btnFarmacia":
                            //Modulo 7
                            button.Tag = typeof(UCInventarioFarmacia);
                           // button.Image = Properties.Resources.icon_farmacia;
                            break;

                        case "btnCirugias":
                            //Modulo 8
                            button.Tag = typeof(UCAgendaCirugias);
                           // button.Image = Properties.Resources.icon_cirugias;
                            break;

                        case "btnHospitalizacion":
                            //Modulo 9
                            button.Tag = typeof(UCAdmisionHospitalaria);
                            //button.Image = Properties.Resources.icon_hospitalizacion;
                            break;

                        case "btnUrgencias":
                            //Modulo 10
                            button.Tag = typeof(UCRegistroUrgencias);
                            //button.Image = Properties.Resources.icon_urgencias;
                            break;

                        case "btnAdministrativo":
                            //Modulo 11
                            button.Tag = typeof(Modulo11);
                            //button.Image = Properties.Resources.icon_administrativo;
                            break;

                        default:
                            button.Tag = null;
                            break;
                    }

                    // Configura el padding para que el icono se vea bien cuando el menú esté colapsado
                    button.Padding = new Padding(15, 0, 0, 0); // Padding a la izquierda para el icono
                    button.TextAlign = ContentAlignment.MiddleLeft;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Text = "  " + button.Text.Trim(); // Asegura un espacio inicial si el texto no lo tiene
                }
            }
            // También configurar el logo y el label dentro del pnlLogo
            lblClinicManager.Text = "CLINIC MGR"; // Texto por defecto
            pbLogo.Image = Properties.Resources.logo_farm; // Asegúrate de tener este recurso
        }

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Tag is Type userControlType)
            {
                ActivateButton(clickedButton);
                LoadUserControl(userControlType);
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
                currentActiveButton.BackColor = Color.FromArgb(0, 123, 255); // Color de resaltado
                currentActiveButton.ForeColor = Color.White;
                currentActiveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void DisableButton(Button buttonToDisable)
        {
            if (buttonToDisable != null)
            {
                buttonToDisable.BackColor = Color.FromArgb(41, 53, 65);
                buttonToDisable.ForeColor = Color.Gainsboro;
                buttonToDisable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void LoadUserControl(Type userControlType)
        {
            if (userControlType == null) return;

            pnlContent.Controls.Clear();
            UserControl newUserControl = (UserControl)Activator.CreateInstance(userControlType);
            newUserControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newUserControl);
            newUserControl.BringToFront();
        }

        // --- Lógica para el colapso/expansión del menú lateral ---

        private void BtnToggleMenu_Click(object sender, EventArgs e)
        {
            tmrMenu.Start(); // Inicia el timer para la animación
        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                // Colapsar el menú
                pnlSideMenu.Width -= 10; // Reduce el ancho gradualmente
                if (pnlSideMenu.Width <= menuCollapseWidth)
                {
                    pnlSideMenu.Width = menuCollapseWidth;
                    tmrMenu.Stop();
                    menuExpanded = false;
                    // Oculta el texto y mueve el label del logo
                    ToggleMenuText(false);
                }
            }
            else
            {
                // Expandir el menú
                pnlSideMenu.Width += 10; // Aumenta el ancho gradualmente
                if (pnlSideMenu.Width >= menuExpandWidth)
                {
                    pnlSideMenu.Width = menuExpandWidth;
                    tmrMenu.Stop();
                    menuExpanded = true;
                    // Muestra el texto y ajusta el label del logo
                    ToggleMenuText(true);
                }
            }
        }

        private void ToggleMenuText(bool showText)
        {
            if (pnlLogo != null)
            {
                if (showText) // Menú Expandido
                {
                    lblClinicManager.Text = "CLINIC MGR";
                    lblClinicManager.Visible = true; // Muestra el label
                    pbLogo.Visible = true;           // <--- ¡AÑADIDO! Muestra el PictureBox

                    // Posición original para el texto del logo y el PictureBox
                    lblClinicManager.Location = new Point(62, 38);
                    pbLogo.Location = new Point(12, 28);

                    // Reposiciona el botón de hamburguesa en el pnlLogo
                    btnToggleMenu.Location = new Point(pnlLogo.Width - btnToggleMenu.Width - 10, btnToggleMenu.Location.Y);
                }
                else // Menú Colapsado
                {
                    lblClinicManager.Visible = false; // Oculta el label del título
                    pbLogo.Visible = false;           // <--- ¡AÑADIDO! Oculta el PictureBox

                    // Si el logo está oculto, su posición no es tan crítica, pero podrías ajustarla
                    // pbLogo.Location = new Point((pnlLogo.Width - pbLogo.Width) / 2, pbLogo.Location.Y); // Ya no es necesario si está oculto

                    // Reposiciona el botón de hamburguesa en el pnlLogo
                    btnToggleMenu.Location = new Point(pnlLogo.Width - btnToggleMenu.Width - 10, btnToggleMenu.Location.Y); // Mantiene margen derecho
                }
            }
            // Muestra u oculta el texto de los botones de navegación
            foreach (Control control in pnlSideMenu.Controls)
            {
                // Asegúrate de que solo procesas botones de menú que tienen asignado un UserControl (Type)
                if (control is Button button && button.Tag is Type)
                {
                    if (showText) // Menú Expandido
                    {
                        // ELIMINA O COMENTA ESTA LÍNEA: 
                        // string originalText = (string)button.Tag; 

                        // USA ESTA LÍNEA PARA RECONSTRUIR EL TEXTO COMPLETO:
                        // button.Name.Replace("btn", "") tomará "Pacientes" de "btnPacientes"
                        button.Text = "  " + button.Name.Replace("btn", "");

                        // El texto del botón original ya está definido en MainForm.Designer.cs, 
                        // pero si quieres ser más específico, puedes crear un nuevo método.

                        // MEJOR OPCIÓN: Asigna el texto predefinido que ya tenías en Designer.cs
                        // Si quieres usar el texto de Designer.cs (ej: "  Gestión de Pacientes 1"), 
                        // necesitarías guardarlo en una propiedad separada. 
                        // Por ahora, usaremos la reconstrucción simple.

                        button.TextAlign = ContentAlignment.MiddleLeft;
                        button.Padding = new Padding(15, 0, 0, 0);
                    }
                    else // Menú Colapsado
                    {
                        button.Text = "";
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Padding = new Padding(0);
                    }

                    // Forzar redibujado
                    button.Invalidate();
                    button.Update();
                }
            }

            // También ajusta el label del logo
            if (showText)
            {
                lblClinicManager.Text = "CLINIC MGR";
                lblClinicManager.Location = new Point(62, 38); // Posición original
                pbLogo.Location = new Point(12, 28);
            }
            else
            {
                lblClinicManager.Text = ""; // Oculta el texto del logo
                lblClinicManager.Location = new Point(0, 0); // Mueve el label fuera de vista
                pbLogo.Location = new Point(10, 28); // Mueve el icono del logo para centrarlo
            }
            btnToggleMenu.Location = new Point(pnlLogo.Width - btnToggleMenu.Width - 10, btnToggleMenu.Location.Y); // Mueve el botón de hamburguesa
        }
    }
}