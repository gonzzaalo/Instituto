using InstitutoDesktop.Services;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Models.MesasExamenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Horarios
{
    public partial class AgregarEditarPeriodoHorarioView : Form
    {
        private BindingSource listaPeriodoHorario = new BindingSource();
        private PeriodoHorario periodoHorario;
        private readonly MemoryCacheServiceWinForms _memoryCache;

        public AgregarEditarPeriodoHorarioView(MemoryCacheServiceWinForms memoryCacheService)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            periodoHorario = new PeriodoHorario();
        }
        public AgregarEditarPeriodoHorarioView(PeriodoHorario periodoHorario)
        {
            InitializeComponent();
            this.periodoHorario = periodoHorario;
            CargarDatosEnPantalla();
        }

        private async void CargarDatosEnPantalla()
        {
            var Datos = listaPeriodoHorario; // Suponiendo que tienes un método para obtener esta lista
            comboBoxCicloLectivo.DataSource = Datos;
            comboBoxCicloLectivo.DisplayMember = "CicloLectivo"; // Nombre de la propiedad a mostrar
            comboBoxCicloLectivo.ValueMember = "CicloLectivoId"; // Nombre de la propiedad de valor único

            // Asigna los valores al resto de controles
            txtNombre.Text = periodoHorario.Nombre;
            chkActual.Checked = periodoHorario.Actual;

            // Selecciona el ciclo lectivo predefinido en el ComboBox
            if (periodoHorario.CicloLectivo != null)
            {
                comboBoxCicloLectivo.SelectedValue = periodoHorario.CicloLectivo.Id;
            }


            //txtNombre.Text = periodoHorario.Nombre;
            //chkActual.Checked = periodoHorario.Actual;
            //comboBoxCicloLectivo.Text = periodoHorario.CicloLectivo.Nombre;
            ////comboBoxCicloLectivo.DataSource = periodoHorario.CicloLectivo;
            ////comboBoxCicloLectivo.Items.Contains(periodoHorario.CicloLectivo);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            //periodoHorario.CicloLectivo = comboBoxCicloLectivo.Text;
            periodoHorario.Nombre = txtNombre.Text;
            periodoHorario.Actual = chkActual.Checked;
            if (periodoHorario.Id == 0)
            {
                await _memoryCache.AddCacheAsync<PeriodoHorario>(periodoHorario, "PeriodosHorarios");
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<PeriodoHorario>(periodoHorario, "PeriodosHorarios");
            }

            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
