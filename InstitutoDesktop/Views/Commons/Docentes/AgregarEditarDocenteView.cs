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
using InstitutoDesktop.Services;

namespace InstitutoDesktop.Views.Commons
{
    public partial class AgregarEditarDocenteView : Form
    {
        private Docente docente;
        private readonly MemoryCacheServiceWinForms _memoryCache;

        public AgregarEditarDocenteView(MemoryCacheServiceWinForms memoryCacheService)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            docente = new Docente();
        }


        public AgregarEditarDocenteView(MemoryCacheServiceWinForms memoryCacheService, Docente docente)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            this.docente = docente;
            CargarDatosDocenteAEditar();
        }

        private async void CargarDatosDocenteAEditar()
        {
           
            
                txtNombre.Text = docente.Nombre;
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            docente.Nombre= txtNombre.Text;

            if (docente.Id == 0)
            {
                await _memoryCache.AddCacheAsync<Docente>(docente, "Docentes");
                //await docenteService.AddAsync(docente);
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<Docente>(docente, "Docentes");
                //await docenteService.UpdateAsync(docente);
            }

            this.Close();
        }
    }
}
