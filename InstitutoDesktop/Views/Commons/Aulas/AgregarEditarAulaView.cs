using InstitutoDesktop.Services;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
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

namespace InstitutoDesktop.Views.Commons.Aulas
{
    public partial class AgregarEditarAulaView : Form
    {
        private Aula aula;
        private readonly MemoryCacheServiceWinForms _memoryCache;

        public AgregarEditarAulaView(MemoryCacheServiceWinForms memoryCacheService)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            aula = new Aula();
        }

        public AgregarEditarAulaView(MemoryCacheServiceWinForms memoryCacheService, Aula aula)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            this.aula = aula;
            CargarDatosAulaAEditar();
        }

        private void CargarDatosAulaAEditar()
        {
            txtNombre.Text = aula.Nombre;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            aula.Nombre = txtNombre.Text;

            if (aula.Id == 0)
            {
                await _memoryCache.AddCacheAsync<Aula>(aula, "Aulas");
                //await aulaService.AddAsync(aula);
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<Aula>(aula, "Aulas");
                //await aulaService.UpdateAsync(aula);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

