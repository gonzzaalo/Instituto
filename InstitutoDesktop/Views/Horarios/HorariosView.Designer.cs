namespace InstitutoDesktop.Views
{
    partial class HorariosView
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
            panel1 = new Panel();
            label6 = new Label();
            cboAniosCarreras = new ComboBox();
            label5 = new Label();
            cboCarreras = new ComboBox();
            label4 = new Label();
            cboCiclosLectivos = new ComboBox();
            label1 = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridHorarios = new DataGridView();
            tabPageAgregarEditar = new TabPage();
<<<<<<< HEAD
            btnEditar = new FontAwesome.Sharp.IconButton();
=======
            BtnEditar = new FontAwesome.Sharp.IconButton();
>>>>>>> 5a0d9051b4859f0ec7a4f4d5965afa15721bcb4b
            cboAulas = new ComboBox();
            label10 = new Label();
            btnQuitarHora = new FontAwesome.Sharp.IconButton();
            btnQuitarDocente = new FontAwesome.Sharp.IconButton();
            dataGridHoras = new DataGridView();
            btnAgregarHora = new FontAwesome.Sharp.IconButton();
            cboDias = new ComboBox();
            label9 = new Label();
            cboHoras = new ComboBox();
            label8 = new Label();
            dataGridDocentes = new DataGridView();
            btnAgregarDocente = new FontAwesome.Sharp.IconButton();
            cboDocentes = new ComboBox();
            label7 = new Label();
            cboMaterias = new ComboBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHorarios).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDocentes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboAniosCarreras);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cboCarreras);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboCiclosLectivos);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 75);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(916, 45);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 7;
            label6.Text = "Año carrera:";
            // 
            // cboAniosCarreras
            // 
            cboAniosCarreras.FormattingEnabled = true;
            cboAniosCarreras.Location = new Point(1035, 38);
            cboAniosCarreras.Margin = new Padding(4);
            cboAniosCarreras.Name = "cboAniosCarreras";
            cboAniosCarreras.Size = new Size(148, 33);
            cboAniosCarreras.TabIndex = 6;
            cboAniosCarreras.SelectedIndexChanged += cboAniosCarreras_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 45);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 5;
            label5.Text = "Carrera:";
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(579, 38);
            cboCarreras.Margin = new Padding(4);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(315, 33);
            cboCarreras.TabIndex = 4;
            cboCarreras.SelectedIndexChanged += cboCarreras_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 3;
            label4.Text = "Ciclo lectivo:";
            // 
            // cboCiclosLectivos
            // 
            cboCiclosLectivos.FormattingEnabled = true;
            cboCiclosLectivos.Location = new Point(294, 38);
            cboCiclosLectivos.Margin = new Padding(4);
            cboCiclosLectivos.Name = "cboCiclosLectivos";
            cboCiclosLectivos.Size = new Size(188, 33);
            cboCiclosLectivos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 0;
            label1.Text = "Horarios";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(1, 81);
            tabControl.Margin = new Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1201, 715);
            tabControl.TabIndex = 1;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(iconButtonSalir);
            tabPageLista.Controls.Add(BtnBuscar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dataGridHorarios);
            tabPageLista.Location = new Point(4, 34);
            tabPageLista.Margin = new Padding(2);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(2);
            tabPageLista.Size = new Size(1193, 677);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonSalir.BackColor = Color.OrangeRed;
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 44;
            iconButtonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.Location = new Point(1030, 285);
            iconButtonSalir.Margin = new Padding(4, 5, 4, 5);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(154, 68);
            iconButtonSalir.TabIndex = 14;
            iconButtonSalir.Text = "&Salir";
            iconButtonSalir.TextAlign = ContentAlignment.MiddleRight;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.OrangeRed;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.White;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1034, 22);
            BtnBuscar.Margin = new Padding(4, 5, 4, 5);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(154, 64);
            BtnBuscar.TabIndex = 13;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 12;
            label3.Text = "Buscar localidad:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(224, 22);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(603, 31);
            txtFiltro.TabIndex = 11;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(1034, 220);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 58);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(1034, 158);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 58);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(1034, 94);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 58);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridHorarios
            // 
            dataGridHorarios.AllowUserToAddRows = false;
            dataGridHorarios.AllowUserToDeleteRows = false;
            dataGridHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHorarios.Location = new Point(8, 79);
            dataGridHorarios.Margin = new Padding(2);
            dataGridHorarios.Name = "dataGridHorarios";
            dataGridHorarios.ReadOnly = true;
            dataGridHorarios.RowHeadersWidth = 62;
            dataGridHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHorarios.Size = new Size(1015, 585);
            dataGridHorarios.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
<<<<<<< HEAD
            tabPageAgregarEditar.Controls.Add(btnEditar);
=======
            tabPageAgregarEditar.Controls.Add(BtnEditar);
>>>>>>> 5a0d9051b4859f0ec7a4f4d5965afa15721bcb4b
            tabPageAgregarEditar.Controls.Add(cboAulas);
            tabPageAgregarEditar.Controls.Add(label10);
            tabPageAgregarEditar.Controls.Add(btnQuitarHora);
            tabPageAgregarEditar.Controls.Add(btnQuitarDocente);
            tabPageAgregarEditar.Controls.Add(dataGridHoras);
            tabPageAgregarEditar.Controls.Add(btnAgregarHora);
            tabPageAgregarEditar.Controls.Add(cboDias);
            tabPageAgregarEditar.Controls.Add(label9);
            tabPageAgregarEditar.Controls.Add(cboHoras);
            tabPageAgregarEditar.Controls.Add(label8);
            tabPageAgregarEditar.Controls.Add(dataGridDocentes);
            tabPageAgregarEditar.Controls.Add(btnAgregarDocente);
            tabPageAgregarEditar.Controls.Add(cboDocentes);
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(cboMaterias);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 34);
            tabPageAgregarEditar.Margin = new Padding(2);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(2);
            tabPageAgregarEditar.Size = new Size(1193, 677);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pager;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(824, 350);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 46);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Modificar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
=======
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEditar.Location = new Point(1031, 477);
            BtnEditar.Margin = new Padding(2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(141, 58);
            BtnEditar.TabIndex = 19;
            BtnEditar.Text = "Editar";
            BtnEditar.TextAlign = ContentAlignment.MiddleRight;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += iconButton1_Click;
>>>>>>> 5a0d9051b4859f0ec7a4f4d5965afa15721bcb4b
            // 
            // cboAulas
            // 
            cboAulas.FormattingEnabled = true;
            cboAulas.Location = new Point(112, 381);
            cboAulas.Margin = new Padding(4);
            cboAulas.Name = "cboAulas";
            cboAulas.Size = new Size(254, 33);
            cboAulas.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 385);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(51, 25);
            label10.TabIndex = 17;
            label10.Text = "Aula:";
            // 
            // btnQuitarHora
            // 
            btnQuitarHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitarHora.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnQuitarHora.IconColor = Color.Black;
            btnQuitarHora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarHora.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            btnQuitarHora.Location = new Point(824, 479);
            btnQuitarHora.Margin = new Padding(2);
            btnQuitarHora.Name = "btnQuitarHora";
            btnQuitarHora.Size = new Size(119, 46);
=======
            btnQuitarHora.Location = new Point(1031, 548);
            btnQuitarHora.Margin = new Padding(2);
            btnQuitarHora.Name = "btnQuitarHora";
            btnQuitarHora.Size = new Size(141, 58);
>>>>>>> 5a0d9051b4859f0ec7a4f4d5965afa15721bcb4b
            btnQuitarHora.TabIndex = 16;
            btnQuitarHora.Text = "Quitar";
            btnQuitarHora.TextAlign = ContentAlignment.MiddleRight;
            btnQuitarHora.UseVisualStyleBackColor = true;
            btnQuitarHora.Click += btnQuitarHora_Click;
            // 
            // btnQuitarDocente
            // 
            btnQuitarDocente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitarDocente.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnQuitarDocente.IconColor = Color.Black;
            btnQuitarDocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarDocente.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitarDocente.Location = new Point(1030, 229);
            btnQuitarDocente.Margin = new Padding(2);
            btnQuitarDocente.Name = "btnQuitarDocente";
            btnQuitarDocente.Size = new Size(142, 58);
            btnQuitarDocente.TabIndex = 15;
            btnQuitarDocente.Text = "Quitar";
            btnQuitarDocente.TextAlign = ContentAlignment.MiddleRight;
            btnQuitarDocente.UseVisualStyleBackColor = true;
            btnQuitarDocente.Click += btnQuitarDocente_Click;
            // 
            // dataGridHoras
            // 
            dataGridHoras.AllowUserToAddRows = false;
            dataGridHoras.AllowUserToDeleteRows = false;
            dataGridHoras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHoras.Location = new Point(55, 438);
            dataGridHoras.Margin = new Padding(2);
            dataGridHoras.Name = "dataGridHoras";
            dataGridHoras.ReadOnly = true;
            dataGridHoras.RowHeadersWidth = 62;
            dataGridHoras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHoras.Size = new Size(968, 219);
            dataGridHoras.TabIndex = 14;
            // 
            // btnAgregarHora
            // 
            btnAgregarHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarHora.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregarHora.IconColor = Color.Black;
            btnAgregarHora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarHora.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarHora.Location = new Point(871, 365);
            btnAgregarHora.Margin = new Padding(2);
            btnAgregarHora.Name = "btnAgregarHora";
            btnAgregarHora.Size = new Size(150, 58);
            btnAgregarHora.TabIndex = 13;
            btnAgregarHora.Text = "Agregar";
            btnAgregarHora.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarHora.UseVisualStyleBackColor = true;
            btnAgregarHora.Click += btnAgregarHora_Click;
            // 
            // cboDias
            // 
            cboDias.FormattingEnabled = true;
            cboDias.Location = new Point(424, 381);
            cboDias.Margin = new Padding(4);
            cboDias.Name = "cboDias";
            cboDias.Size = new Size(179, 33);
            cboDias.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 388);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 11;
            label9.Text = "Día:";
            // 
            // cboHoras
            // 
            cboHoras.FormattingEnabled = true;
            cboHoras.Location = new Point(684, 378);
            cboHoras.Margin = new Padding(4);
            cboHoras.Name = "cboHoras";
            cboHoras.Size = new Size(174, 33);
            cboHoras.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(621, 385);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 9;
            label8.Text = "Hora:";
            // 
            // dataGridDocentes
            // 
            dataGridDocentes.AllowUserToAddRows = false;
            dataGridDocentes.AllowUserToDeleteRows = false;
            dataGridDocentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDocentes.Location = new Point(58, 180);
            dataGridDocentes.Margin = new Padding(2);
            dataGridDocentes.Name = "dataGridDocentes";
            dataGridDocentes.ReadOnly = true;
            dataGridDocentes.RowHeadersWidth = 62;
            dataGridDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDocentes.Size = new Size(964, 148);
            dataGridDocentes.TabIndex = 8;
            // 
            // btnAgregarDocente
            // 
            btnAgregarDocente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarDocente.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregarDocente.IconColor = Color.Black;
            btnAgregarDocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarDocente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarDocente.Location = new Point(651, 84);
            btnAgregarDocente.Margin = new Padding(2);
            btnAgregarDocente.Name = "btnAgregarDocente";
            btnAgregarDocente.Size = new Size(150, 58);
            btnAgregarDocente.TabIndex = 7;
            btnAgregarDocente.Text = "Agregar";
            btnAgregarDocente.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarDocente.UseVisualStyleBackColor = true;
            btnAgregarDocente.Click += btnAgregarDocente_Click;
            // 
            // cboDocentes
            // 
            cboDocentes.FormattingEnabled = true;
            cboDocentes.Location = new Point(152, 96);
            cboDocentes.Margin = new Padding(4);
            cboDocentes.Name = "cboDocentes";
            cboDocentes.Size = new Size(469, 33);
            cboDocentes.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 101);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 5;
            label7.Text = "Docente:";
            // 
            // cboMaterias
            // 
            cboMaterias.FormattingEnabled = true;
            cboMaterias.Location = new Point(152, 22);
            cboMaterias.Margin = new Padding(4);
            cboMaterias.Name = "cboMaterias";
            cboMaterias.Size = new Size(469, 33);
            cboMaterias.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(1026, 97);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 71);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(1026, 22);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 71);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 0;
            label2.Text = "Materia:";
            // 
            // HorariosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 792);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "HorariosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHorarios).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDocentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private DataGridView dataGridHorarios;
        private TabPage tabPageAgregarEditar;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private Label label3;
        private TextBox txtFiltro;
        private Label label4;
        private ComboBox cboCiclosLectivos;
        private Label label5;
        private ComboBox cboCarreras;
        private Label label6;
        private ComboBox cboAniosCarreras;
        private ComboBox cboDocentes;
        private Label label7;
        private ComboBox cboMaterias;
        private ComboBox cboHoras;
        private Label label8;
        private DataGridView dataGridDocentes;
        private FontAwesome.Sharp.IconButton btnAgregarDocente;
        private DataGridView dataGridHoras;
        private FontAwesome.Sharp.IconButton btnAgregarHora;
        private ComboBox cboDias;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnQuitarHora;
        private FontAwesome.Sharp.IconButton btnQuitarDocente;
        private ComboBox cboAulas;
        private Label label10;
<<<<<<< HEAD
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEditar;
=======
        private FontAwesome.Sharp.IconButton BtnEditar;
>>>>>>> 5a0d9051b4859f0ec7a4f4d5965afa15721bcb4b
    }
}