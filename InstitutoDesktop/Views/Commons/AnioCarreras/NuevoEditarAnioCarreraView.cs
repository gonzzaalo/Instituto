using InstitutoDesktop.Services;
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
        AnioCarrera anioCarrera;
        private readonly MemoryCacheServiceWinForms _memoryCache;

        // NUEVO
        public NuevoEditarAnioCarreraView(MemoryCacheServiceWinForms memoryCacheService,Carrera carrera)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            anioCarrera = new AnioCarrera();
            anioCarrera.CarreraId = carrera.Id;
            txtCarrera.Text = carrera.Nombre;
        }

        //EDITAR

        public NuevoEditarAnioCarreraView(MemoryCacheServiceWinForms memoryCacheService, AnioCarrera anioCarrera)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            this.anioCarrera = anioCarrera;
            txtCarrera.Text = anioCarrera?.Carrera?.Nombre;
            txtNombreAnioCarrera.Text = anioCarrera.Nombre;
        }

     

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            anioCarrera.Nombre = txtNombreAnioCarrera.Text;

            if (anioCarrera.Id == 0)
            {
                await _memoryCache.AddCacheAsync<AnioCarrera>(anioCarrera, "AniosCarreras");
                //await anioCarreraService.AddAsync(anioCarrera);
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<AnioCarrera>(anioCarrera, "AniosCarreras");
                //await anioCarreraService.UpdateAsync(anioCarrera);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
