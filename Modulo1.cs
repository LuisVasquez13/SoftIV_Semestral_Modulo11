using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Borrador
{
    public partial class Modulo1 : UserControl
    {
        // Colores del tema
        private readonly Color PrimaryBlue = Color.FromArgb(41, 68, 123);
        private readonly Color SecondaryBlue = Color.FromArgb(56, 97, 181);
        private readonly Color AccentBlue = Color.FromArgb(66, 117, 206);
        private readonly Color LightBlue = Color.FromArgb(100, 149, 237);
        private readonly Color BackgroundGray = Color.FromArgb(248, 249, 251);
        private readonly Color CardWhite = Color.White;
        private readonly Color BorderGray = Color.FromArgb(226, 232, 240);
        private readonly Color TextDark = Color.FromArgb(30, 41, 59);
        private readonly Color TextGray = Color.FromArgb(100, 116, 139);

        // Datos en memoria
        private readonly List<Dictionary<string, object>> listaPacientes = new List<Dictionary<string, object>>();
        private BindingSource bsPacientes;

        // Controles para "Ver pacientes"
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtSearch;
        private DataGridView dgvPacientes;
        private Button btnAgregar;
        private Button btnVerHistoria;
        private Button btnFiltros;
        private Panel pnlStats;

        // Controles para "Añadir/Editar paciente"
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbSexo;
        private ComboBox cbEstadoCivil;
        private TextBox txtTelefono;
        private TextBox txtContactoEmergencia;
        private TextBox txtAlergias;
        private TextBox txtAntecedentes;
        private TextBox txtSeguro;
        private TextBox txtPoliza;
        private Button btnGuardar;
        private Button btnCancelar;

        // Estado de edición
        private int? editingId = null;

        // Controles para "Historia"
        private TextBox txtHistAntecedentes;
        private TextBox txtHistAlergias;
        private TextBox txtHistCirugias;
        private TextBox txtHistMedicacion;
        private TextBox txtHistObservaciones;
        private Button btnExportarHistoria;
        private Button btnImprimirHistoria;

        public Modulo1()
        {
            InitializeComponent();
            this.BackColor = BackgroundGray;
            InicializarPacientesTabs();
            CargarDatosPrueba();
            RefrescarGrilla();
            tabControl1.SelectedTab = tabPage3;
        }

        private void InicializarPacientesTabs()
        {
            // Estilo del TabControl
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(150, 40);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Tab "Ver pacientes"
            ConstruirVistaListaPacientes(tabPage3);

            // Tab "Añadir paciente"
            ConstruirFormularioPaciente(tabPage1);

            // Tab "Historia"
            ConstruirHistoriaPaciente(tabPage2);
        }

        private void ConstruirVistaListaPacientes(TabPage tab)
        {
            tab.Controls.Clear();
            tab.BackColor = BackgroundGray;

            // Panel principal con padding
            var mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24),
                BackColor = BackgroundGray
            };

            // Header con título y subtítulo
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = BackgroundGray
            };

            lblTitle = new Label
            {
                Text = "Sistema de Gestión de Pacientes",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = TextDark,
                AutoSize = true,
                Location = new Point(0, 0)
            };

            lblSubtitle = new Label
            {
                Text = "Gestione los registros de los pacientes, las admisiones y el historial médico de manera eficiente",
                Font = new Font("Segoe UI", 10F),
                ForeColor = TextGray,
                AutoSize = true,
                Location = new Point(0, 40)
            };

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // Panel de estadísticas (cards superiores)
            pnlStats = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = BackgroundGray,
                Padding = new Padding(0, 12, 0, 12)
            };

            var statCard1 = CrearStatCard("TOTAL DE PACIENTES", listaPacientes.Count.ToString(), "+12% since last month");
            var statCard2 = CrearStatCard("INGRESADOS", "42", "Current admissions");

            statCard1.Location = new Point(0, 12);
            statCard1.Width = 280;
            statCard2.Location = new Point(300, 12);
            statCard2.Width = 280;

            pnlStats.Controls.Add(statCard1);
            pnlStats.Controls.Add(statCard2);

            // Barra de acciones (búsqueda y botones)
            var actionBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = BackgroundGray,
                Padding = new Padding(0, 8, 0, 8)
            };

            // Búsqueda
            txtSearch = new TextBox
            {
                Width = 350,
                Height = 38,
                Location = new Point(0, 16),
                Font = new Font("Segoe UI", 10F),
                ForeColor = TextGray,
                Text = "Buscar por nombre, ID o teléfono...",
                BorderStyle = BorderStyle.FixedSingle
            };
            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == "Buscar por nombre, ID o teléfono...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = TextDark;
                }
            };
            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Buscar por nombre, ID o teléfono...";
                    txtSearch.ForeColor = TextGray;
                }
            };

            // Botones de acción
            btnAgregar = CrearBotonModerno("+ Añadir Paciente", SecondaryBlue);
            btnAgregar.Location = new Point(actionBar.Width - 380, 16);
            btnAgregar.Size = new Size(160, 38);
            btnAgregar.Click += (s, e) => IrATabAgregarNuevo();

            btnFiltros = CrearBotonModerno("⚙ Filtros", Color.FromArgb(226, 232, 240));
            btnFiltros.ForeColor = TextDark;
            btnFiltros.Location = new Point(actionBar.Width - 210, 16);
            btnFiltros.Size = new Size(100, 38);

            btnVerHistoria = CrearBotonModerno("📋 Ver Historia", LightBlue);
            btnVerHistoria.Location = new Point(actionBar.Width - 100, 16);
            btnVerHistoria.Size = new Size(100, 38);
            btnVerHistoria.Click += (s, e) => IrATabHistoriaDesdeSeleccion();

            actionBar.Controls.Add(txtSearch);
            actionBar.Controls.Add(btnAgregar);
            actionBar.Controls.Add(btnFiltros);
            actionBar.Controls.Add(btnVerHistoria);

            actionBar.Resize += (s, e) =>
            {
                btnAgregar.Location = new Point(actionBar.Width - 380, 16);
                btnFiltros.Location = new Point(actionBar.Width - 210, 16);
                btnVerHistoria.Location = new Point(actionBar.Width - 100, 16);
            };

            // DataGridView con estilo moderno
            var dgvContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = CardWhite,
                Padding = new Padding(1)
            };

            dgvPacientes = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns = false,
                BackgroundColor = CardWhite,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                EnableHeadersVisualStyles = false,
                GridColor = BorderGray,
                RowHeadersVisible = false,
                Font = new Font("Segoe UI", 9.5F),
                RowTemplate = { Height = 50 }
            };

            // Estilo del header
            dgvPacientes.ColumnHeadersDefaultCellStyle.BackColor = BackgroundGray;
            dgvPacientes.ColumnHeadersDefaultCellStyle.ForeColor = TextGray;
            dgvPacientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPacientes.ColumnHeadersDefaultCellStyle.Padding = new Padding(8);
            dgvPacientes.ColumnHeadersHeight = 45;

            // Estilo de las celdas
            dgvPacientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvPacientes.DefaultCellStyle.SelectionForeColor = TextDark;
            dgvPacientes.DefaultCellStyle.Padding = new Padding(8, 5, 8, 5);
            dgvPacientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            // Columnas
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "NOMBRE",
                DataPropertyName = "NombreCompleto",
                Width = 200
            });

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CÉDULA)",
                DataPropertyName = "Cedula",
                Width = 150
            });

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "FECHA DE NACIMIENTO",
                DataPropertyName = "FechaNacimiento",
                Width = 120
            });

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "TELÉFONO",
                DataPropertyName = "Telefono",
                Width = 130
            });

            var colEditar = new DataGridViewButtonColumn
            {
                HeaderText = "ACCIONES",
                Text = "✏️",
                UseColumnTextForButtonValue = true,
                Width = 80,
                FlatStyle = FlatStyle.Flat
            };

            var colEliminar = new DataGridViewButtonColumn
            {
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                Width = 80,
                FlatStyle = FlatStyle.Flat
            };

            dgvPacientes.Columns.Add(colEditar);
            dgvPacientes.Columns.Add(colEliminar);

            dgvPacientes.CellClick += DgvPacientes_CellClick;

            bsPacientes = new BindingSource();
            dgvPacientes.DataSource = bsPacientes;

            dgvContainer.Controls.Add(dgvPacientes);

            mainContainer.Controls.Add(dgvContainer);
            mainContainer.Controls.Add(actionBar);
            mainContainer.Controls.Add(pnlStats);
            mainContainer.Controls.Add(pnlHeader);

            tab.Controls.Add(mainContainer);
        }

        private Panel CrearStatCard(string titulo, string valor, string detalle)
        {
            var card = new Panel
            {
                Height = 76,
                BackColor = CardWhite,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(16)
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = TextGray,
                AutoSize = true,
                Location = new Point(16, 12)
            };

            var lblValor = new Label
            {
                Text = valor,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = PrimaryBlue,
                AutoSize = true,
                Location = new Point(16, 30)
            };

            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblValor);

            return card;
        }

        private Button CrearBotonModerno(string texto, Color colorFondo)
        {
            var btn = new Button
            {
                Text = texto,
                BackColor = colorFondo,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = AjustarBrillo(colorFondo, -20);
            return btn;
        }

        private Color AjustarBrillo(Color color, int ajuste)
        {
            return Color.FromArgb(
                Math.Max(0, Math.Min(255, color.R + ajuste)),
                Math.Max(0, Math.Min(255, color.G + ajuste)),
                Math.Max(0, Math.Min(255, color.B + ajuste))
            );
        }

        private void ConstruirFormularioPaciente(TabPage tab)
        {
            tab.Controls.Clear();
            tab.BackColor = BackgroundGray;

            var mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24),
                BackColor = BackgroundGray,
                AutoScroll = true
            };

            // Card principal con el formulario
            var formCard = new Panel
            {
                Dock = DockStyle.Top,
                Height = 700,
                BackColor = CardWhite,
                Padding = new Padding(24)
            };

            var main = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 12,
                AutoScroll = true
            };
            main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            txtNombre = CrearTextBoxModerno();
            txtApellido = CrearTextBoxModerno();
            txtCedula = CrearTextBoxModerno();
            dtpFechaNacimiento = new DateTimePicker { Format = DateTimePickerFormat.Short, Font = new Font("Segoe UI", 10F) };
            cbSexo = CrearComboBoxModerno();
            cbEstadoCivil = CrearComboBoxModerno();
            txtTelefono = CrearTextBoxModerno();
            txtContactoEmergencia = CrearTextBoxModerno();
            txtAlergias = new TextBox { Multiline = true, Height = 80, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle };
            txtAntecedentes = new TextBox { Multiline = true, Height = 80, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle };
            txtSeguro = CrearTextBoxModerno();
            txtPoliza = CrearTextBoxModerno();

            cbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cbEstadoCivil.Items.AddRange(new object[] { "Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a" });

            void AddRow(string labelText, Control control, int row)
            {
                var lbl = new Label
                {
                    Text = labelText,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    ForeColor = TextDark
                };
                var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 5, 10, 5) };
                control.Dock = DockStyle.Top;
                panel.Controls.Add(control);
                main.Controls.Add(lbl, 0, row);
                main.Controls.Add(panel, 1, row);
            }

            AddRow("Nombre:", txtNombre, 0);
            AddRow("Apellido:", txtApellido, 1);
            AddRow("Cédula:", txtCedula, 2);
            AddRow("Fecha nacimiento:", dtpFechaNacimiento, 3);
            AddRow("Sexo:", cbSexo, 4);
            AddRow("Estado civil:", cbEstadoCivil, 5);
            AddRow("Teléfono:", txtTelefono, 6);
            AddRow("Contacto emergencia:", txtContactoEmergencia, 7);
            AddRow("Alergias:", txtAlergias, 8);
            AddRow("Antecedentes:", txtAntecedentes, 9);
            AddRow("Seguro:", txtSeguro, 10);
            AddRow("Póliza:", txtPoliza, 11);

            formCard.Controls.Add(main);

            // Panel de botones
            var buttonsPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 70,
                BackColor = CardWhite,
                Padding = new Padding(24, 12, 24, 12)
            };

            btnGuardar = CrearBotonModerno("Guardar", SecondaryBlue);
            btnGuardar.Size = new Size(130, 42);
            btnGuardar.Location = new Point(24, 14);
            btnGuardar.Click += BtnGuardar_Click;

            btnCancelar = CrearBotonModerno("Cancelar", Color.Gray);
            btnCancelar.Size = new Size(130, 42);
            btnCancelar.Location = new Point(164, 14);
            btnCancelar.Click += (s, e) =>
            {
                LimpiarFormulario();
                editingId = null;
                tabControl1.SelectedTab = tabPage3;
            };

            buttonsPanel.Controls.Add(btnGuardar);
            buttonsPanel.Controls.Add(btnCancelar);

            formCard.Controls.Add(buttonsPanel);

            mainContainer.Controls.Add(formCard);
            tab.Controls.Add(mainContainer);
        }

        private TextBox CrearTextBoxModerno()
        {
            return new TextBox
            {
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle,
                Height = 32
            };
        }

        private ComboBox CrearComboBoxModerno()
        {
            return new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F),
                FlatStyle = FlatStyle.Flat
            };
        }

        private void ConstruirHistoriaPaciente(TabPage tab)
        {
            tab.Controls.Clear();
            tab.BackColor = BackgroundGray;

            var mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24),
                BackColor = BackgroundGray
            };

            var historyCard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = CardWhite,
                Padding = new Padding(24)
            };

            var main = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 6, Padding = new Padding(10) };
            main.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            main.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            main.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            txtHistAntecedentes = new TextBox { Dock = DockStyle.Fill, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle, BackColor = BackgroundGray };
            txtHistAlergias = new TextBox { Dock = DockStyle.Fill, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle, BackColor = BackgroundGray };
            txtHistCirugias = new TextBox { Dock = DockStyle.Fill, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle, BackColor = BackgroundGray };
            txtHistMedicacion = new TextBox { Dock = DockStyle.Fill, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle, BackColor = BackgroundGray };
            txtHistObservaciones = new TextBox { Dock = DockStyle.Fill, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), BorderStyle = BorderStyle.FixedSingle, BackColor = BackgroundGray };

            var lblAntecedentes = new Label { Text = "Resumen de antecedentes", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = TextDark };
            var lblAlergias = new Label { Text = "Alergias", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = TextDark };
            var lblOtros = new Label { Text = "Cirugías / Medicación / Observaciones", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = TextDark };

            main.Controls.Add(lblAntecedentes, 0, 0);
            main.Controls.Add(txtHistAntecedentes, 0, 1);
            main.Controls.Add(lblAlergias, 0, 2);
            main.Controls.Add(txtHistAlergias, 0, 3);
            main.Controls.Add(lblOtros, 0, 4);

            var lowerLayout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3 };
            lowerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            lowerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            lowerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34));
            lowerLayout.Controls.Add(txtHistCirugias, 0, 0);
            lowerLayout.Controls.Add(txtHistMedicacion, 1, 0);
            lowerLayout.Controls.Add(txtHistObservaciones, 2, 0);
            main.Controls.Add(lowerLayout, 0, 5);

            var btnPanel = new Panel { Dock = DockStyle.Bottom, Height = 70, Padding = new Padding(24, 12, 24, 12), BackColor = CardWhite };

            btnExportarHistoria = CrearBotonModerno("📄 Exportar (TXT)", SecondaryBlue);
            btnExportarHistoria.Size = new Size(150, 42);
            btnExportarHistoria.Location = new Point(24, 14);
            btnExportarHistoria.Click += BtnExportarHistoria_Click;

            btnImprimirHistoria = CrearBotonModerno("🖨️ Imprimir", AccentBlue);
            btnImprimirHistoria.Size = new Size(130, 42);
            btnImprimirHistoria.Location = new Point(184, 14);
            btnImprimirHistoria.Click += BtnImprimirHistoria_Click;

            btnPanel.Controls.Add(btnExportarHistoria);
            btnPanel.Controls.Add(btnImprimirHistoria);

            historyCard.Controls.Add(main);
            historyCard.Controls.Add(btnPanel);

            mainContainer.Controls.Add(historyCard);
            tab.Controls.Add(mainContainer);
        }

        private void CargarDatosPrueba()
        {
            listaPacientes.Clear();
            listaPacientes.Add(new Dictionary<string, object>
            {
                ["Id"] = 1,
                ["NombreCompleto"] = "Carlos Gómez",
                ["Nombre"] = "Carlos",
                ["Apellido"] = "Gómez",
                ["Cedula"] = "8-123-4567",
                ["FechaNacimiento"] = new DateTime(1992, 4, 15).ToShortDateString(),
                ["Sexo"] = "Masculino",
                ["EstadoCivil"] = "Soltero",
                ["Telefono"] = "6000-1111",
                ["ContactoEmergencia"] = "Ana Gómez - 6000-2222",
                ["Alergias"] = "Ninguna",
                ["Antecedentes"] = "Hipertensión familiar",
                ["Seguro"] = "Seguro XYZ",
                ["Poliza"] = "POL-0001"
            });

            listaPacientes.Add(new Dictionary<string, object>
            {
                ["Id"] = 2,
                ["NombreCompleto"] = "María López",
                ["Nombre"] = "María",
                ["Apellido"] = "López",
                ["Cedula"] = "8-765-4321",
                ["FechaNacimiento"] = new DateTime(1997, 9, 30).ToShortDateString(),
                ["Sexo"] = "Femenino",
                ["EstadoCivil"] = "Casado",
                ["Telefono"] = "7000-2222",
                ["ContactoEmergencia"] = "Pedro López - 7000-3333",
                ["Alergias"] = "Penicilina",
                ["Antecedentes"] = "Asma",
                ["Seguro"] = "Seguro ABC",
                ["Poliza"] = "POL-0102"
            });
        }

        private void RefrescarGrilla()
        {
            var listaAnonima = new List<object>();
            foreach (var d in listaPacientes)
            {
                listaAnonima.Add(new
                {
                    Id = $"#{d["Id"]}",
                    NombreCompleto = $"{d["Nombre"]} {d["Apellido"]}",
                    Cedula = d["Cedula"],
                    FechaNacimiento = d["FechaNacimiento"],
                    Telefono = $"📞 {d["Telefono"]}"
                });
            }
            bsPacientes.DataSource = listaAnonima;

            // Actualizar estadísticas
            if (pnlStats != null && pnlStats.Controls.Count > 0)
            {
                var card = pnlStats.Controls[0] as Panel;
                if (card != null && card.Controls.Count > 1)
                {
                    var lblValor = card.Controls[1] as Label;
                    if (lblValor != null)
                    {
                        lblValor.Text = listaPacientes.Count.ToString();
                    }
                }
            }
        }

        private void IrATabAgregarNuevo()
        {
            editingId = null;
            LimpiarFormulario();
            tabControl1.SelectedTab = tabPage1;
            txtNombre.Focus();
        }

        private void IrATabHistoriaDesdeSeleccion()
        {
            var pac = ObtenerPacienteSeleccionado();
            if (pac == null)
            {
                MessageBox.Show("Selecciona un paciente primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CargarHistoriaDesdePaciente(pac);
            tabControl1.SelectedTab = tabPage2;
        }

        private Dictionary<string, object> ObtenerPacienteSeleccionado()
        {
            if (dgvPacientes?.CurrentRow == null) return null;
            string idStr = dgvPacientes.CurrentRow.Cells[0].Value.ToString().Replace("#", "");
            int id = Convert.ToInt32(idStr);
            return listaPacientes.Find(p => Convert.ToInt32(p["Id"]) == id);
        }

        private void DgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 5) // Editar
            {
                string idStr = dgvPacientes.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("#", "");
                int id = Convert.ToInt32(idStr);
                var pac = listaPacientes.Find(p => Convert.ToInt32(p["Id"]) == id);
                if (pac != null)
                {
                    editingId = id;
                    CargarFormularioDesdeDiccionario(pac);
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            else if (e.ColumnIndex == 6) // Eliminar
            {
                string idStr = dgvPacientes.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("#", "");
                int id = Convert.ToInt32(idStr);
                var pac = listaPacientes.Find(p => Convert.ToInt32(p["Id"]) == id);
                if (pac != null)
                {
                    string nombre = pac.ContainsKey("NombreCompleto") && pac["NombreCompleto"] != null
                        ? pac["NombreCompleto"].ToString()
                        : ($"{pac["Nombre"]} {pac["Apellido"]}");
                    var respuesta = MessageBox.Show($"¿Eliminar al paciente {nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        listaPacientes.RemoveAll(x => Convert.ToInt32(x["Id"]) == id);
                        RefrescarGrilla();
                    }
                }
            }
        }

        private void CargarFormularioDesdeDiccionario(Dictionary<string, object> pac)
        {
            txtNombre.Text = pac.ContainsKey("Nombre") ? pac["Nombre"].ToString() : string.Empty;
            txtApellido.Text = pac.ContainsKey("Apellido") ? pac["Apellido"].ToString() : string.Empty;
            txtCedula.Text = pac.ContainsKey("Cedula") ? pac["Cedula"].ToString() : string.Empty;
            if (pac.ContainsKey("FechaNacimiento"))
            {
                if (DateTime.TryParse(pac["FechaNacimiento"]?.ToString(), out var dt))
                    dtpFechaNacimiento.Value = dt;
            }
            cbSexo.SelectedItem = pac.ContainsKey("Sexo") ? pac["Sexo"] : null;
            cbEstadoCivil.SelectedItem = pac.ContainsKey("EstadoCivil") ? pac["EstadoCivil"] : null;
            txtTelefono.Text = pac.ContainsKey("Telefono") ? pac["Telefono"].ToString() : string.Empty;
            txtContactoEmergencia.Text = pac.ContainsKey("ContactoEmergencia") ? pac["ContactoEmergencia"].ToString() : string.Empty;
            txtAlergias.Text = pac.ContainsKey("Alergias") ? pac["Alergias"].ToString() : string.Empty;
            txtAntecedentes.Text = pac.ContainsKey("Antecedentes") ? pac["Antecedentes"].ToString() : string.Empty;
            txtSeguro.Text = pac.ContainsKey("Seguro") ? pac["Seguro"].ToString() : string.Empty;
            txtPoliza.Text = pac.ContainsKey("Poliza") ? pac["Poliza"].ToString() : string.Empty;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCedula.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Today;
            cbSexo.SelectedIndex = -1;
            cbEstadoCivil.SelectedIndex = -1;
            txtTelefono.Text = string.Empty;
            txtContactoEmergencia.Text = string.Empty;
            txtAlergias.Text = string.Empty;
            txtAntecedentes.Text = string.Empty;
            txtSeguro.Text = string.Empty;
            txtPoliza.Text = string.Empty;
        }

        private Dictionary<string, object> ObtenerDatosFormulario()
        {
            var datos = new Dictionary<string, object>();
            datos["Nombre"] = txtNombre.Text.Trim();
            datos["Apellido"] = txtApellido.Text.Trim();
            datos["NombreCompleto"] = $"{txtNombre.Text.Trim()} {txtApellido.Text.Trim()}".Trim();
            datos["Cedula"] = txtCedula.Text.Trim();
            datos["FechaNacimiento"] = dtpFechaNacimiento.Value.ToShortDateString();
            datos["Sexo"] = cbSexo.SelectedItem ?? string.Empty;
            datos["EstadoCivil"] = cbEstadoCivil.SelectedItem ?? string.Empty;
            datos["Telefono"] = txtTelefono.Text.Trim();
            datos["ContactoEmergencia"] = txtContactoEmergencia.Text.Trim();
            datos["Alergias"] = txtAlergias.Text.Trim();
            datos["Antecedentes"] = txtAntecedentes.Text.Trim();
            datos["Seguro"] = txtSeguro.Text.Trim();
            datos["Poliza"] = txtPoliza.Text.Trim();
            return datos;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var datos = ObtenerDatosFormulario();
            if (editingId.HasValue)
            {
                var idx = listaPacientes.FindIndex(p => Convert.ToInt32(p["Id"]) == editingId.Value);
                if (idx >= 0)
                {
                    datos["Id"] = editingId.Value;
                    listaPacientes[idx] = datos;
                }
            }
            else
            {
                int nuevoId = listaPacientes.Count > 0 ? Convert.ToInt32(listaPacientes[listaPacientes.Count - 1]["Id"]) + 1 : 1;
                datos["Id"] = nuevoId;
                listaPacientes.Add(datos);
            }

            editingId = null;
            RefrescarGrilla();
            LimpiarFormulario();
            tabControl1.SelectedTab = tabPage3;
        }

        private void CargarHistoriaDesdePaciente(Dictionary<string, object> pac)
        {
            txtHistAntecedentes.Text = pac.ContainsKey("Antecedentes") ? pac["Antecedentes"].ToString() : string.Empty;
            txtHistAlergias.Text = pac.ContainsKey("Alergias") ? pac["Alergias"].ToString() : string.Empty;
            txtHistCirugias.Text = pac.ContainsKey("Cirugias") ? pac["Cirugias"].ToString() : string.Empty;
            txtHistMedicacion.Text = pac.ContainsKey("MedicacionHabitual") ? pac["MedicacionHabitual"].ToString() : string.Empty;
            txtHistObservaciones.Text = pac.ContainsKey("Observaciones") ? pac["Observaciones"].ToString() : string.Empty;
        }

        private void BtnExportarHistoria_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "Text files|*.txt", FileName = "historia_clinica.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine("Resumen de antecedentes:");
                            sw.WriteLine(txtHistAntecedentes.Text);
                            sw.WriteLine();
                            sw.WriteLine("Alergias:");
                            sw.WriteLine(txtHistAlergias.Text);
                            sw.WriteLine();
                            sw.WriteLine("Cirugías:");
                            sw.WriteLine(txtHistCirugias.Text);
                            sw.WriteLine();
                            sw.WriteLine("Medicación habitual:");
                            sw.WriteLine(txtHistMedicacion.Text);
                            sw.WriteLine();
                            sw.WriteLine("Observaciones generales:");
                            sw.WriteLine(txtHistObservaciones.Text);
                        }
                        MessageBox.Show("Exportado correctamente.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnImprimirHistoria_Click(object sender, EventArgs e)
        {
            var preview = new PrintPreviewDialog();
            var pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                float y = 20;
                var font = new Font("Segoe UI", 10);
                ev.Graphics.DrawString("Resumen de antecedentes:", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, 20, y);
                y += 26;
                ev.Graphics.DrawString(txtHistAntecedentes.Text, font, Brushes.Black, new RectangleF(20, y, ev.MarginBounds.Width, 200));
            };
            preview.Document = pd;
            try
            {
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar la impresión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}