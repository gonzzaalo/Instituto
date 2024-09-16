using InstitutoServices.Models;
using InstitutoServices.Models.Commons;
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

namespace InstitutoDesktop.Views.Commons.AnioCarreras
{
    public partial class NuevoEditarAnioCarreraView : Form
    {
        AnioCarreraService anioCarreraService = new AnioCarreraService();
        AnioCarrera anioCarrera;

        // NUEVO
        public NuevoEditarAnioCarreraView(Carrera carrera)
        {
            InitializeComponent();
            anioCarrera = new AnioCarrera();
            anioCarrera.CarreraId = carrera.Id;
            txtCarrera.Text = carrera.Nombre;
        }

        //EDITAR

        public NuevoEditarAnioCarreraView(AnioCarrera anioCarrera)
        {
            InitializeComponent();
            this.anioCarrera = anioCarrera;
            txtCarrera.Text = anioCarrera?.Carrera?.Nombre;
            txtNombreAnioCarrera.Text = anioCarrera.Nombre;
        }

     

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            anioCarrera.Nombre = txtNombreAnioCarrera.Text;

            if (anioCarrera.Id == 0)
            {
                await anioCarreraService.AddAsync(anioCarrera);
            }
            else
            {
                await anioCarreraService.UpdateAsync(anioCarrera);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
