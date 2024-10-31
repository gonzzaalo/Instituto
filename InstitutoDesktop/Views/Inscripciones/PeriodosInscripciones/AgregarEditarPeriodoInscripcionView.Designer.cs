namespace InstitutoDesktop.Views.Inscripciones
{
    partial class AgregarEditarPeriodoInscripcionView
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
            label1 = new Label();
            chInscripcionActiva = new CheckBox();
            cboCiclosLectivos = new ComboBox();
            label2 = new Label();
            chMaterias2doCuatrimestre = new CheckBox();
            LabelTitulo = new Label();
            txtNombre = new TextBox();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 125);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // chInscripcionActiva
            // 
            chInscripcionActiva.AutoSize = true;
            chInscripcionActiva.Location = new Point(100, 239);
            chInscripcionActiva.Name = "chInscripcionActiva";
            chInscripcionActiva.Size = new Size(147, 24);
            chInscripcionActiva.TabIndex = 1;
            chInscripcionActiva.Text = "Inscripcion Activa";
            chInscripcionActiva.UseVisualStyleBackColor = true;
            // 
            // cboCiclosLectivos
            // 
            cboCiclosLectivos.FormattingEnabled = true;
            cboCiclosLectivos.Location = new Point(515, 117);
            cboCiclosLectivos.Name = "cboCiclosLectivos";
            cboCiclosLectivos.Size = new Size(231, 28);
            cboCiclosLectivos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 125);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Ciclo Lectivo:";
            // 
            // chMaterias2doCuatrimestre
            // 
            chMaterias2doCuatrimestre.AutoSize = true;
            chMaterias2doCuatrimestre.Location = new Point(380, 239);
            chMaterias2doCuatrimestre.Name = "chMaterias2doCuatrimestre";
            chMaterias2doCuatrimestre.Size = new Size(381, 24);
            chMaterias2doCuatrimestre.TabIndex = 5;
            chMaterias2doCuatrimestre.Text = "Visualizar únicamente materias del 2do Cuatrimentre";
            chMaterias2doCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.ForeColor = Color.Blue;
            LabelTitulo.Location = new Point(222, 25);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(421, 36);
            LabelTitulo.TabIndex = 6;
            LabelTitulo.Text = "Agregar/Editar Período Inscripción";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gray;
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.File;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnSalir.IconSize = 24;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(553, 317);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(15, 0, 0, 0);
            btnSalir.Size = new Size(127, 69);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(91, 312);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(15, 0, 0, 0);
            btnAgregar.Size = new Size(127, 74);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarEditarPeriodoInscripcionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(LabelTitulo);
            Controls.Add(chMaterias2doCuatrimestre);
            Controls.Add(cboCiclosLectivos);
            Controls.Add(label2);
            Controls.Add(chInscripcionActiva);
            Controls.Add(label1);
            Name = "AgregarEditarPeriodoInscripcionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar/Editar Periodo Inscripción";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chInscripcionActiva;
        private ComboBox cboCiclosLectivos;
        private Label label2;
        private CheckBox chMaterias2doCuatrimestre;
        private Label LabelTitulo;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}