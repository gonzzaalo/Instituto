namespace InstitutoDesktop.Views.Commons.Aulas
{
    partial class AulasView
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
            dataGridAulas = new DataGridView();
            iconSalir = new FontAwesome.Sharp.IconButton();
            iconEliminar = new FontAwesome.Sharp.IconButton();
            iconEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridAulas).BeginInit();
            SuspendLayout();
            // 
            // dataGridAulas
            // 
            dataGridAulas.AllowUserToAddRows = false;
            dataGridAulas.AllowUserToDeleteRows = false;
            dataGridAulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAulas.Location = new Point(47, 88);
            dataGridAulas.Margin = new Padding(3, 4, 3, 4);
            dataGridAulas.Name = "dataGridAulas";
            dataGridAulas.ReadOnly = true;
            dataGridAulas.RowHeadersWidth = 62;
            dataGridAulas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAulas.Size = new Size(784, 414);
            dataGridAulas.TabIndex = 17;
            // 
            // iconSalir
            // 
            iconSalir.IconChar = FontAwesome.Sharp.IconChar.File;
            iconSalir.IconColor = Color.Black;
            iconSalir.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconSalir.IconSize = 24;
            iconSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconSalir.Location = new Point(743, 537);
            iconSalir.Margin = new Padding(3, 4, 3, 4);
            iconSalir.Name = "iconSalir";
            iconSalir.Size = new Size(127, 40);
            iconSalir.TabIndex = 21;
            iconSalir.Text = "Salir";
            iconSalir.UseVisualStyleBackColor = true;
            iconSalir.Click += iconSalir_Click;
            // 
            // iconEliminar
            // 
            iconEliminar.IconChar = FontAwesome.Sharp.IconChar.File;
            iconEliminar.IconColor = Color.Black;
            iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconEliminar.IconSize = 24;
            iconEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconEliminar.Location = new Point(382, 537);
            iconEliminar.Margin = new Padding(3, 4, 3, 4);
            iconEliminar.Name = "iconEliminar";
            iconEliminar.Size = new Size(127, 40);
            iconEliminar.TabIndex = 20;
            iconEliminar.Text = "Eliminar";
            iconEliminar.UseVisualStyleBackColor = true;
            iconEliminar.Click += iconEliminar_Click;
            // 
            // iconEditar
            // 
            iconEditar.IconChar = FontAwesome.Sharp.IconChar.File;
            iconEditar.IconColor = Color.Black;
            iconEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconEditar.IconSize = 24;
            iconEditar.ImageAlign = ContentAlignment.MiddleLeft;
            iconEditar.Location = new Point(200, 537);
            iconEditar.Margin = new Padding(3, 4, 3, 4);
            iconEditar.Name = "iconEditar";
            iconEditar.Size = new Size(127, 40);
            iconEditar.TabIndex = 19;
            iconEditar.Text = "Editar";
            iconEditar.UseVisualStyleBackColor = true;
            iconEditar.Click += iconEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(27, 537);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 40);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AulasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 612);
            Controls.Add(iconSalir);
            Controls.Add(iconEliminar);
            Controls.Add(iconEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridAulas);
            Name = "AulasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aulas";
            ((System.ComponentModel.ISupportInitialize)dataGridAulas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridAulas;
        private FontAwesome.Sharp.IconButton iconSalir;
        private FontAwesome.Sharp.IconButton iconEliminar;
        private FontAwesome.Sharp.IconButton iconEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}