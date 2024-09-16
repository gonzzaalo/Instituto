using InstitutoServices.Interfaces;
using InstitutoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstitutoServices.Models;
using InstitutoServices.Services.Commons;
using InstitutoServices.Models.Commons;

namespace InstitutoDesktop.Views.Commons
{
    public partial class AgregarEditarCarreraView : Form
    {
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();
        private Carrera carrera;

        //nuevo
        public AgregarEditarCarreraView()
        {
            InitializeComponent();
            carrera=new Carrera();
        }

        //editar
        public AgregarEditarCarreraView(Carrera carrera)
        {
            InitializeComponent();
            this.carrera = carrera;
            CargarDatosCarreraAEditar();
        }

        private async void CargarDatosCarreraAEditar()
        {
            txtNombre.Text = carrera.Nombre;
            txtSigla.Text = carrera.Sigla;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            carrera.Nombre = txtNombre.Text;
            carrera.Sigla = txtSigla.Text;
            
            if (carrera.Id == 0)
            {
                await carreraService.AddAsync(carrera);
            }
            else
            {
                await carreraService.UpdateAsync(carrera);
            }
            this.Close();
        }
    }
}
