namespace InstitutoDesktop.Views.Horarios
{
    partial class AgregarEditarPeriodoHorarioView
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
            lblCicloLectivoHorarioView = new Label();
            comboBoxCicloLectivo = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            chkActual = new CheckBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            chMaterias2doCuatrimestre = new CheckBox();
            SuspendLayout();
            // 
            // lblCicloLectivoHorarioView
            // 
            lblCicloLectivoHorarioView.AutoSize = true;
            lblCicloLectivoHorarioView.Location = new Point(95, 85);
            lblCicloLectivoHorarioView.Name = "lblCicloLectivoHorarioView";
            lblCicloLectivoHorarioView.Size = new Size(93, 20);
            lblCicloLectivoHorarioView.TabIndex = 21;
            lblCicloLectivoHorarioView.Text = "Ciclo Lectivo";
            // 
            // comboBoxCicloLectivo
            // 
            comboBoxCicloLectivo.FormattingEnabled = true;
            comboBoxCicloLectivo.Location = new Point(216, 82);
            comboBoxCicloLectivo.Name = "comboBoxCicloLectivo";
            comboBoxCicloLectivo.Size = new Size(455, 28);
            comboBoxCicloLectivo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(95, 144);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 144);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(455, 27);
            txtNombre.TabIndex = 24;
            // 
            // chkActual
            // 
            chkActual.AutoSize = true;
            chkActual.Location = new Point(95, 215);
            chkActual.Name = "chkActual";
            chkActual.Size = new Size(73, 24);
            chkActual.TabIndex = 25;
            chkActual.Text = "Actual";
            chkActual.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(419, 306);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 40);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(258, 306);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 40);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chMaterias2doCuatrimestre
            // 
            chMaterias2doCuatrimestre.AutoSize = true;
            chMaterias2doCuatrimestre.Location = new Point(355, 215);
            chMaterias2doCuatrimestre.Name = "chMaterias2doCuatrimestre";
            chMaterias2doCuatrimestre.Size = new Size(300, 24);
            chMaterias2doCuatrimestre.TabIndex = 28;
            chMaterias2doCuatrimestre.Text = "Visualizar materias del 2do Cuatrimentre";
            chMaterias2doCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // AgregarEditarPeriodoHorarioView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chMaterias2doCuatrimestre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActual);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblCicloLectivoHorarioView);
            Controls.Add(comboBoxCicloLectivo);
            Name = "AgregarEditarPeriodoHorarioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar/Editar Perdiodo Horario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCicloLectivoHorarioView;
        private ComboBox comboBoxCicloLectivo;
        private Label lblNombre;
        private TextBox txtNombre;
        private CheckBox chkActual;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private CheckBox chMaterias2doCuatrimestre;
    }
}