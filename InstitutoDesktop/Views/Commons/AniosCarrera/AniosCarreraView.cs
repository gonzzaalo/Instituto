using InstitutoDesktop.ExtensionMethods;
using InstitutoServices.Services;
using InstitutoDesktop.Views.Commons.AniosCarrera;
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

namespace InstitutoDesktop.Views.AniosCarrera
{
    public partial class AniosCarreraView : Form
    {
        GenericService<Carrera> carreraService = new GenericService<Carrera>();
        AnioCarreraService anioCarreraService = new AnioCarreraService();
        BindingSource listaAniosCarrera = new BindingSource();
        BindingSource listaCarreras = new BindingSource();

        public AniosCarreraView()
        {
            InitializeComponent();
            dataGridAniosCarrera.DataSource = listaAniosCarrera;
            cboCarreras.DataSource = listaCarreras;
            CargarCboCarreras();
            CargarDatosGrilla();
        }

        private async void CargarCboCarreras()
        {
            listaCarreras.DataSource = await carreraService.GetAllAsync();
            cboCarreras.DisplayMember = "Nombre";
            cboCarreras.ValueMember = "Id";
            CargarDatosGrilla();
        }

        private async void CargarDatosGrilla()
        {
            if (cboCarreras.SelectedValue != null && cboCarreras.SelectedValue.GetType() == typeof(int))
            {
                var idCarrera = (int)cboCarreras.SelectedValue;
                listaAniosCarrera.DataSource = await anioCarreraService.GetByCarreraAsync(idCarrera);
                dataGridAniosCarrera.OcultarColumnas(new string[] { "Carrera", "CarreraId", "AñoYCarrera" });
                dataGridAniosCarrera.EstablecerAnchoDeColumnas(new int[] { 100, 300 });
            }
        }

        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarDatosGrilla();

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (AnioCarrera)listaAniosCarrera.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Año {anioCarrera.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await anioCarreraService.DeleteAsync(anioCarrera.Id);
                CargarDatosGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            NuevoEditarAnioCarreraView nuevoEditarAnioCarreraView = new NuevoEditarAnioCarreraView(carrera);
            nuevoEditarAnioCarreraView.ShowDialog();
            CargarDatosGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (AnioCarrera)listaAniosCarrera.Current;
            NuevoEditarAnioCarreraView nuevoEditarAnioCarreraView = new NuevoEditarAnioCarreraView(anioCarrera);
            nuevoEditarAnioCarreraView.ShowDialog();
            CargarDatosGrilla();
        }
    }
}
