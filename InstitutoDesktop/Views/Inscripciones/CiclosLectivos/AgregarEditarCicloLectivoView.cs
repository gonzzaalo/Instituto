using InstitutoDesktop.Services;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Inscripciones;
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
using System.Windows.Media.Media3D;

namespace InstitutoDesktop.Views.Inscripciones
{
    public partial class AgregarEditarCicloLectivoView : Form
    {
        private CicloLectivo cicloLectivo;
        private readonly MemoryCacheServiceWinForms _memoryCache;

        public AgregarEditarCicloLectivoView(MemoryCacheServiceWinForms memoryCacheService)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            cicloLectivo = new CicloLectivo();
            CargarDatosCicloLectivoAEditar();
        }
        public AgregarEditarCicloLectivoView(MemoryCacheServiceWinForms memoryCacheService, CicloLectivo cicloLectivo)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            this.cicloLectivo=null;
            this.cicloLectivo = cicloLectivo;
            CargarDatosCicloLectivoAEditar();
        }

        private async void CargarDatosCicloLectivoAEditar()
        {


            txtNombre.Text = cicloLectivo.Nombre;
            chkActual.Checked = cicloLectivo.Actual;


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            cicloLectivo.Nombre = txtNombre.Text;
            cicloLectivo.Actual = chkActual.Checked;

            if (cicloLectivo.Id == 0)
            {
                await _memoryCache.AddCacheAsync<CicloLectivo>(cicloLectivo, "CiclosLectivos");
                //await ciclolectivoService.AddAsync(cicloLectivo);
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<CicloLectivo>(cicloLectivo, "CiclosLectivos");
                //await ciclolectivoService.UpdateAsync(cicloLectivo);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
