namespace InstitutoDesktop.Views.Commons
{
    partial class ErrorView
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
            TxtPilaDeLlamada = new TextBox();
            label4 = new Label();
            TxtCodigo = new TextBox();
            label3 = new Label();
            BtnAceptar = new Button();
            TxtMensajeError = new TextBox();
            TxtNumeroError = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDetalleError = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // TxtPilaDeLlamada
            // 
            TxtPilaDeLlamada.BackColor = SystemColors.Window;
            TxtPilaDeLlamada.Font = new Font("Segoe UI", 11F);
            TxtPilaDeLlamada.Location = new Point(192, 412);
            TxtPilaDeLlamada.Margin = new Padding(4, 5, 4, 5);
            TxtPilaDeLlamada.Multiline = true;
            TxtPilaDeLlamada.Name = "TxtPilaDeLlamada";
            TxtPilaDeLlamada.ReadOnly = true;
            TxtPilaDeLlamada.Size = new Size(847, 131);
            TxtPilaDeLlamada.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(104, 414);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 34);
            label4.TabIndex = 16;
            label4.Text = "Pila :";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Font = new Font("Segoe UI", 11F);
            TxtCodigo.Location = new Point(192, 262);
            TxtCodigo.Margin = new Padding(4, 5, 4, 5);
            TxtCodigo.Multiline = true;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.ReadOnly = true;
            TxtCodigo.Size = new Size(847, 131);
            TxtCodigo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(56, 264);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 34);
            label3.TabIndex = 14;
            label3.Text = "Código :";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnAceptar.Location = new Point(910, 37);
            BtnAceptar.Margin = new Padding(4, 5, 4, 5);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(151, 68);
            BtnAceptar.TabIndex = 13;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // TxtMensajeError
            // 
            TxtMensajeError.Font = new Font("Segoe UI", 11F);
            TxtMensajeError.Location = new Point(192, 104);
            TxtMensajeError.Margin = new Padding(4, 5, 4, 5);
            TxtMensajeError.Multiline = true;
            TxtMensajeError.Name = "TxtMensajeError";
            TxtMensajeError.ReadOnly = true;
            TxtMensajeError.Size = new Size(847, 131);
            TxtMensajeError.TabIndex = 12;
            // 
            // TxtNumeroError
            // 
            TxtNumeroError.Font = new Font("Segoe UI", 11F);
            TxtNumeroError.Location = new Point(192, 24);
            TxtNumeroError.Margin = new Padding(4, 5, 4, 5);
            TxtNumeroError.Name = "TxtNumeroError";
            TxtNumeroError.ReadOnly = true;
            TxtNumeroError.Size = new Size(354, 37);
            TxtNumeroError.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(46, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 34);
            label2.TabIndex = 10;
            label2.Text = "Mensaje :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.Location = new Point(46, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 34);
            label1.TabIndex = 9;
            label1.Text = "Error N ° :";
            // 
            // txtDetalleError
            // 
            txtDetalleError.BackColor = SystemColors.Window;
            txtDetalleError.Font = new Font("Segoe UI", 11F);
            txtDetalleError.Location = new Point(192, 567);
            txtDetalleError.Margin = new Padding(4, 5, 4, 5);
            txtDetalleError.Multiline = true;
            txtDetalleError.Name = "txtDetalleError";
            txtDetalleError.ReadOnly = true;
            txtDetalleError.Size = new Size(847, 131);
            txtDetalleError.TabIndex = 19;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.Location = new Point(19, 567);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 77);
            label5.TabIndex = 18;
            label5.Text = "Detalles del error:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ErrorView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 712);
            Controls.Add(txtDetalleError);
            Controls.Add(label5);
            Controls.Add(TxtPilaDeLlamada);
            Controls.Add(label4);
            Controls.Add(TxtCodigo);
            Controls.Add(label3);
            Controls.Add(BtnAceptar);
            Controls.Add(TxtMensajeError);
            Controls.Add(TxtNumeroError);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ErrorView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ErrorView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPilaDeLlamada;
        private Label label4;
        private TextBox TxtCodigo;
        private Label label3;
        private Button BtnAceptar;
        private TextBox TxtMensajeError;
        private TextBox TxtNumeroError;
        private Label label2;
        private Label label1;
        private TextBox txtDetalleError;
        private Label label5;
    }
}