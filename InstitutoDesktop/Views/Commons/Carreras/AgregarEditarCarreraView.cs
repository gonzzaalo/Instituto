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
using InstitutoDesktop.Util;

namespace InstitutoDesktop.Views.Commons
{
    public partial class AgregarEditarCarreraView : Form
    {
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();
        private readonly MemoryCacheService _memoryCache;

        private Carrera carrera;

        //nuevo
        public AgregarEditarCarreraView(MemoryCacheService memoryCache)
        {
            InitializeComponent();
            carrera=new Carrera();
            _memoryCache = memoryCache;
        }

        //editar
        public AgregarEditarCarreraView(MemoryCacheService memoryCache,Carrera carrera)
        {
            InitializeComponent();
            this.carrera = carrera;
            _memoryCache = memoryCache;
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
            
            ShowInActivity.Show("Guardando los cambios");
            if (carrera.Id == 0)
            {
                await _memoryCache.AddCache(carrera, "Carreras");
                //await carreraService.AddAsync(carrera);
            }
            else
            {
                //UPDATE
                await _memoryCache.UpdateCache<Carrera>(carrera, "Carreras");

                //await carreraService.UpdateAsync(carrera);
            }
            ShowInActivity.Hide();
            this.Close();
        }
    }
}
