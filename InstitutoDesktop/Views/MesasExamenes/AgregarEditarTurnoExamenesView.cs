using InstitutoServices.Models;
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
using InstitutoServices.Services.Commons;
using InstitutoServices.Models.MesasExamenes;
using InstitutoDesktop.Services;

namespace InstitutoDesktop.Views.MesasExamenes
{
    public partial class AgregarEditarTurnoExamenesView : Form
    {
        private TurnoExamen turnoexamen;
        private readonly MemoryCacheServiceWinForms _memoryCache;

        public AgregarEditarTurnoExamenesView(MemoryCacheServiceWinForms memoryCacheService)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            turnoexamen = new TurnoExamen();
        }

        public AgregarEditarTurnoExamenesView(TurnoExamen turnoexamen)
        {
            InitializeComponent();
            this.turnoexamen = turnoexamen;
            CargarDatosEnPantalla();
        }

        private async void CargarDatosEnPantalla()
        {
            txtNombre.Text = turnoexamen.Nombre;
            checkBox1.Checked = turnoexamen.Actual; // Cargar el estado del checkbox
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            turnoexamen.Nombre = txtNombre.Text;
            turnoexamen.Actual = checkBox1.Checked;
            if (turnoexamen.Id == 0)
            {
                //await turnoexamenesService.AddAsync(turnoexamen);
                await _memoryCache.AddCacheAsync<TurnoExamen>(turnoexamen, "TurnosExamenes");
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<TurnoExamen>(turnoexamen, "TurnosExamenes");
                //await turnoexamenesService.UpdateAsync(turnoexamen);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
