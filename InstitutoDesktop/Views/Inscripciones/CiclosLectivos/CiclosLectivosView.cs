using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Services;
using InstitutoDesktop.Util;
using InstitutoDesktop.Views.Commons.Materias;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.DependencyInjection;

namespace InstitutoDesktop.Views.Inscripciones
{


    public partial class CiclosLectivosView : Form
    {
        BindingSource listaCicloLectivos = new BindingSource();
        private readonly MemoryCacheServiceWinForms _memoryCache;
        private readonly IServiceProvider _serviceProvider;

        public CiclosLectivosView(MemoryCacheServiceWinForms memoryCacheService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            _serviceProvider = serviceProvider;
            dataGridCiclosLectivos.DataSource = listaCicloLectivos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaCicloLectivos.DataSource = null;
            listaCicloLectivos.DataSource = await _memoryCache.GetAllCacheAsync<CicloLectivo>("CiclosLectivos");
            dataGridCiclosLectivos.OcultarColumnas(new string[] { "Eliminado" });
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = ActivatorUtilities.CreateInstance<AgregarEditarCicloLectivoView>(_serviceProvider);
            agregarEditarCicloLectivoView.ShowDialog();

            await CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var ciclolectivo = (CicloLectivo)listaCicloLectivos.Current;
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = 
        ActivatorUtilities.CreateInstance<AgregarEditarCicloLectivoView>(_serviceProvider, ciclolectivo);
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var ciclolectivo = (CicloLectivo)listaCicloLectivos.Current;

            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Ciclo Lectivo {ciclolectivo.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //await ciclolectivoService.DeleteAsync(ciclolectivo.Id);
                await _memoryCache.DeleteCacheAsync<CicloLectivo>(ciclolectivo.Id, "CiclosLectivos");
                await CargarGrilla();
            }
        }
    }
}
