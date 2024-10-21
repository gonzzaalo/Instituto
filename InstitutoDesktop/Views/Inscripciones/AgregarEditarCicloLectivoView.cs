using InstitutoServices.Interfaces;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Services;
using InstitutoServices.Services.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace InstitutoDesktop.Views.Inscripciones
{
    public partial class AgregarEditarCicloLectivoView : Form
    {
        IGenericService<CicloLectivo> ciclolectivoService = new GenericService<CicloLectivo>();
        private CicloLectivo cicloLectivo;
        public AgregarEditarCicloLectivoView()
        {
            InitializeComponent();
            cicloLectivo = new CicloLectivo();
        }
        public AgregarEditarCicloLectivoView(CicloLectivo cicloLectivo)
        {
            InitializeComponent();
            this.cicloLectivo = cicloLectivo;
            CargarDatosCicloLectivoAEditar();
        }

        private async void CargarDatosCicloLectivoAEditar()
        {


            txtNombre.Text = cicloLectivo.Nombre;
            chkActual.Checked = cicloLectivo.Actual;


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            cicloLectivo.Nombre = txtNombre.Text;
            cicloLectivo.Actual = chkActual.Checked;

            if (cicloLectivo.Id == 0)
            {
                await ciclolectivoService.AddAsync(cicloLectivo);
            }
            else
            {
                await ciclolectivoService.UpdateAsync(cicloLectivo);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
