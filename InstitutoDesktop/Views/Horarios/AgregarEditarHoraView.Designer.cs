namespace InstitutoDesktop.Views.Horarios
{
    partial class AgregarEditarHoraView
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
            txtNombre = new TextBox();
            label1 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            chkRecreo = new CheckBox();
            dateTimeDesde = new DateTimePicker();
            dateTimeHasta = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(385, 243);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(320, 37);
            txtNombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(278, 250);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 11;
            label1.Text = "Hora:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(532, 386);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 50);
            btnCancelar.TabIndex = 10;
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
            btnGuardar.Location = new Point(330, 386);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(159, 50);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkRecreo
            // 
            chkRecreo.AutoSize = true;
            chkRecreo.Location = new Point(278, 309);
            chkRecreo.Margin = new Padding(4, 4, 4, 4);
            chkRecreo.Name = "chkRecreo";
            chkRecreo.Size = new Size(91, 29);
            chkRecreo.TabIndex = 14;
            chkRecreo.Text = "Recreo";
            chkRecreo.UseVisualStyleBackColor = true;
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Time;
            dateTimeDesde.Location = new Point(385, 80);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(155, 31);
            dateTimeDesde.TabIndex = 15;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Time;
            dateTimeHasta.Location = new Point(385, 145);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(155, 31);
            dateTimeHasta.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(285, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 17;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(285, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 18;
            label3.Text = "Hasta:";
            // 
            // AgregarEditarHoraView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 589);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimeHasta);
            Controls.Add(dateTimeDesde);
            Controls.Add(chkRecreo);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AgregarEditarHoraView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private CheckBox chkRecreo;
        private DateTimePicker dateTimeDesde;
        private DateTimePicker dateTimeHasta;
        private Label label2;
        private Label label3;
    }
}