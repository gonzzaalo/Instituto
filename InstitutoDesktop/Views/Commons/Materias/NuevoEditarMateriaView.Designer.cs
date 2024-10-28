namespace InstitutoDesktop.Views.Commons.Materias
{
    partial class NuevoEditarMateriaView
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
            txtMateria = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtAnioYCarrera = new TextBox();
            label3 = new Label();
            chkEsRecreo = new CheckBox();
            SuspendLayout();
            // 
            // txtMateria
            // 
            txtMateria.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMateria.Location = new Point(170, 275);
            txtMateria.Margin = new Padding(4, 4, 4, 4);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(799, 41);
            txtMateria.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 276);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 16;
            label2.Text = "Materia:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 64, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(790, 460);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 58);
            btnCancelar.TabIndex = 14;
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
            btnGuardar.Location = new Point(31, 460);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 58);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtAnioYCarrera
            // 
            txtAnioYCarrera.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnioYCarrera.Location = new Point(210, 179);
            txtAnioYCarrera.Margin = new Padding(4, 4, 4, 4);
            txtAnioYCarrera.Name = "txtAnioYCarrera";
            txtAnioYCarrera.ReadOnly = true;
            txtAnioYCarrera.Size = new Size(759, 41);
            txtAnioYCarrera.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 40);
            label3.TabIndex = 19;
            label3.Text = "Año y Carrera:";
            // 
            // chkEsRecreo
            // 
            chkEsRecreo.AutoSize = true;
            chkEsRecreo.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEsRecreo.Location = new Point(170, 357);
            chkEsRecreo.Name = "chkEsRecreo";
            chkEsRecreo.Size = new Size(164, 43);
            chkEsRecreo.TabIndex = 22;
            chkEsRecreo.Text = "Es recreo";
            chkEsRecreo.UseVisualStyleBackColor = true;
            // 
            // NuevoEditarMateriaView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1000, 562);
            Controls.Add(chkEsRecreo);
            Controls.Add(txtAnioYCarrera);
            Controls.Add(label3);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NuevoEditarMateriaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Editar Materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMateria;
        private Label label2;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtAnioYCarrera;
        private Label label3;
        private CheckBox chkEsRecreo;
    }
}