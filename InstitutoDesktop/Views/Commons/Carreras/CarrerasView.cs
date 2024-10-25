using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoDesktop.Views.Commons;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.DependencyInjection;

namespace InstitutoDesktop.Views
{
    public partial class CarrerasView : Form
    {
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();
        BindingSource listaCarreras = new BindingSource();
        private readonly MemoryCacheService _memoryCache;
        private readonly IServiceProvider _serviceProvider;


        public CarrerasView(MemoryCacheService memoryCacheService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            dataGridCarreras.DataSource = listaCarreras;
            CargarGrilla();
            _serviceProvider = serviceProvider;
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de carreras");
            listaCarreras.DataSource = null;
            listaCarreras.DataSource = await _memoryCache.GetAllCache<Carrera>("Carreras");

            //listaCarreras.DataSource = await carreraService.GetAllAsync();
            dataGridCarreras.OcultarColumnas(new string[] { "Eliminado" });
            ShowInActivity.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCarreraView agregarEditarCarreraView = _serviceProvider.GetRequiredService<AgregarEditarCarreraView>();
            agregarEditarCarreraView.ShowDialog();
            CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a la carrera {carrera.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ShowInActivity.Show("Eliminando carrera");
                await _memoryCache.DeleteCache<Carrera>(carrera.Id, "Carreras");
                ShowInActivity.Hide();
                await CargarGrilla();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            var agregarEditarCarreraView = ActivatorUtilities.CreateInstance<AgregarEditarCarreraView>(_serviceProvider, carrera);
            agregarEditarCarreraView.ShowDialog();
            await CargarGrilla();
        }
    }
}
