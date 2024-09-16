namespace InstitutoDesktop.Views.AniosCarrera
{
    partial class AniosCarreraView
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
            dataGridAniosCarrera = new DataGridView();
            cboCarreras = new ComboBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAniosCarrera).BeginInit();
            SuspendLayout();
            // 
            // dataGridAniosCarrera
            // 
            dataGridAniosCarrera.AllowUserToAddRows = false;
            dataGridAniosCarrera.AllowUserToDeleteRows = false;
            dataGridAniosCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAniosCarrera.Location = new Point(66, 104);
            dataGridAniosCarrera.Name = "dataGridAniosCarrera";
            dataGridAniosCarrera.ReadOnly = true;
            dataGridAniosCarrera.RowHeadersWidth = 62;
            dataGridAniosCarrera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAniosCarrera.Size = new Size(641, 304);
            dataGridAniosCarrera.TabIndex = 0;
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(184, 33);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(434, 33);
            cboCarreras.TabIndex = 1;
            cboCarreras.SelectedIndexChanged += cboCarreras_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 2;
            label1.Text = "Carrera:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(79, 443);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(211, 443);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(354, 443);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(651, 466);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // AniosCarreraView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 533);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(cboCarreras);
            Controls.Add(dataGridAniosCarrera);
            Name = "AniosCarreraView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Años de las carreras";
            ((System.ComponentModel.ISupportInitialize)dataGridAniosCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridAniosCarrera;
        private ComboBox cboCarreras;
        private Label label1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}