using InstitutoDesktop.ExtensionMethods;
using InstitutoServices.Services;
using InstitutoDesktop.Views.Commons.AnioCarreras;
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

namespace InstitutoDesktop.Views.Commons.Materias
{
    public partial class MateriaView : Form
    {
        GenericService<Carrera> carreraService = new GenericService<Carrera>();
        AnioCarreraService anioCarreraService = new AnioCarreraService();
        MateriaService materiaService = new MateriaService();
        BindingSource listaAniosCarrera = new BindingSource();
        BindingSource listaCarreras = new BindingSource();
        BindingSource listaMaterias = new BindingSource();

        public MateriaView()
        {
            InitializeComponent();

            // Asignar DataSources
            dataGridMaterias.DataSource = listaMaterias;
            cboCarreras.DataSource = listaCarreras;
            cboAniosCarreras.DataSource = listaAniosCarrera;

            // Cargar datos en los ComboBox
            CargarCboCarreras();

            // Agregar eventos
            cboCarreras.SelectedIndexChanged += new EventHandler(CargarAniosCarrerasPorCarreraSeleccionada);
            cboAniosCarreras.SelectedIndexChanged += new EventHandler(FiltrosCambiados);
        }

        private async void CargarCboCarreras()
        {
            listaCarreras.DataSource = await carreraService.GetAllAsync();
            cboCarreras.DisplayMember = "Nombre";
            cboCarreras.ValueMember = "Id";

            // Si hay alguna carrera seleccionada, cargar los años correspondientes
            if (cboCarreras.Items.Count > 0)
            {
                cboCarreras.SelectedIndex = 0; // Seleccionar la primera carrera
                CargarAniosCarrerasPorCarreraSeleccionada(null, null);
            }
        }

        private async void CargarAniosCarrerasPorCarreraSeleccionada(object? sender, EventArgs? e)
        {
            if (cboCarreras.SelectedValue is int carreraId)
            {
                listaAniosCarrera.DataSource = await anioCarreraService.GetByCarreraAsync(carreraId);
                cboAniosCarreras.DisplayMember = "Nombre";
                cboAniosCarreras.ValueMember = "Id";

                // Si hay algún año seleccionado, actualizar la grilla
                if (cboAniosCarreras.Items.Count > 0)
                {
                    cboAniosCarreras.SelectedIndex = 0; // Seleccionar el primer año
                    await CargarDatosEnGrilla();
                }
            }
        }

        private async void FiltrosCambiados(object sender, EventArgs e)
        {
            await CargarDatosEnGrilla();
        }

        private async Task CargarDatosEnGrilla()
        {
            if (cboCarreras.SelectedValue is int carreraId && cboAniosCarreras.SelectedValue is int anioCarreraId)
            {
                var materias = await materiaService.GetByAnioCarreraAsync(anioCarreraId);
                listaMaterias.DataSource = materias;
                dataGridMaterias.OcultarColumnas(new string[] { "AnioCarreraId", "AnioCarrera", "Eliminado" });
                dataGridMaterias.EstablecerAnchoDeColumnas(new int[] { 100, 350 });
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener la carrera y el año seleccionados
            var carrera = (Carrera)listaCarreras.Current;
            var anioCarrera = (AnioCarrera)listaAniosCarrera.Current;

            // Crear el formulario para agregar una nueva materia
            NuevoEditarMateriaView nuevoEditarMateriaView = new NuevoEditarMateriaView(carrera, anioCarrera);

            // Mostrar el formulario como diálogo
            nuevoEditarMateriaView.ShowDialog();

            // Si se agregó la materia, actualizar la grilla
            CargarDatosEnGrilla();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var materia = (Materia)listaMaterias.Current;
            var aniocarrera = (AnioCarrera)listaAniosCarrera.Current;
            NuevoEditarMateriaView nuevoEditarMateriaView = new NuevoEditarMateriaView(materia,aniocarrera);
            nuevoEditarMateriaView.ShowDialog();
            CargarDatosEnGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var materia = (Materia)listaMaterias.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar la materia {materia.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await materiaService.DeleteAsync(materia.Id);
                CargarDatosEnGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
