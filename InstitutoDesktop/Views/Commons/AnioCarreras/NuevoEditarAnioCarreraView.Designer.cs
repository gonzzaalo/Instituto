namespace InstitutoDesktop.Views.Commons.AnioCarreras
{
    partial class NuevoEditarAnioCarreraView
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtCarrera = new TextBox();
            txtNombreAnioCarrera = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 64, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(713, 437);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 46);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(106, 437);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 46);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 106);
            label1.Name = "label1";
            label1.Size = new Size(105, 34);
            label1.TabIndex = 9;
            label1.Text = "Carrera:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 258);
            label2.Name = "label2";
            label2.Size = new Size(106, 34);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // txtCarrera
            // 
            txtCarrera.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.Location = new Point(217, 105);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(640, 35);
            txtCarrera.TabIndex = 11;
            // 
            // txtNombreAnioCarrera
            // 
            txtNombreAnioCarrera.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreAnioCarrera.Location = new Point(217, 257);
            txtNombreAnioCarrera.Name = "txtNombreAnioCarrera";
            txtNombreAnioCarrera.Size = new Size(640, 35);
            txtNombreAnioCarrera.TabIndex = 12;
            // 
            // NuevoEditarAnioCarreraView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(920, 538);
            Controls.Add(txtNombreAnioCarrera);
            Controls.Add(txtCarrera);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "NuevoEditarAnioCarreraView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Editar Año Carrera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private TextBox txtCarrera;
        private TextBox txtNombreAnioCarrera;
    }
}