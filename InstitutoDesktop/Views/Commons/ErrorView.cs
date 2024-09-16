using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Commons
{
    public partial class ErrorView : Form
    {
        private Exception exepcion;

        public ErrorView()
        {
            InitializeComponent();
        }

        public ErrorView(Exception exepcion)
        {
            InitializeComponent();
            this.exepcion = exepcion;
            MostrarDatosDelError();
        }

        private void MostrarDatosDelError()
        {
            TxtNumeroError.Text=exepcion.HResult.ToString();
            TxtCodigo.Text = exepcion.Source;
            TxtMensajeError.Text = exepcion.Message;
            TxtPilaDeLlamada.Text= exepcion.StackTrace;
            if (exepcion.InnerException != null)
            {
                var exep=exepcion.InnerException;
                txtDetalleError.Text = $"Nro error={exep.HResult.ToString()}"+Environment.NewLine; txtDetalleError.Text += $"Código={exep.Source}"+Environment.NewLine;
                txtDetalleError.Text += $"Mensaje={exep.Message}"+Environment.NewLine;
            }
        }
    }
}
