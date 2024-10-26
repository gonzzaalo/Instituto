using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Services;
using InstitutoDesktop.Util;
using InstitutoDesktop.Views.Commons.AnioCarreras;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Commons.Aulas
{
    public partial class AulasView : Form
    {
        BindingSource BindingAula = new BindingSource();
        List<Aula> listAula = new List<Aula>();
        private readonly MemoryCacheServiceWinForms _memoryCache;
        private readonly IServiceProvider _serviceProvider;

        public AulasView(MemoryCacheServiceWinForms memoryCacheService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            _serviceProvider = serviceProvider;

            dataGridAulas.DataSource = BindingAula;
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            listAula = await _memoryCache.GetAllCacheAsync<Aula>("Aulas");
            dataGridAulas.OcultarColumnas(new string[] { "Eliminado" });
            BindingAula.DataSource = null;
            BindingAula.DataSource = listAula;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarAulaView agregarEditarAulaView = ActivatorUtilities.CreateInstance<AgregarEditarAulaView>(_serviceProvider);
            agregarEditarAulaView.ShowDialog();
            CargarGrilla();
        }

        private async void iconEditar_Click(object sender, EventArgs e)
        {
            var aula = (Aula)BindingAula.Current;
            AgregarEditarAulaView agregarEditarAulaView = ActivatorUtilities.CreateInstance<AgregarEditarAulaView>(_serviceProvider, aula);
            agregarEditarAulaView.ShowDialog();
           await CargarGrilla();
        }

        private async void iconEliminar_Click(object sender, EventArgs e)
        {

            var aula = (Aula)BindingAula.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el aula {aula.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await _memoryCache.DeleteCacheAsync<Aula>(aula.Id, "Aulas");
                await CargarGrilla();
            }
        }

        private void iconSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
