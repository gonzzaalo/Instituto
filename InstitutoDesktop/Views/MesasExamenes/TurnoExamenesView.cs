using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Interfaces;
using InstitutoServices.Services;
using InstitutoDesktop.Views.Inscripciones;
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
using InstitutoServices.Models.MesasExamenes;

namespace InstitutoDesktop.Views.MesasExamenes
{
    public partial class TurnoExamenesView : Form
    {
        IGenericService<TurnoExamen> turnoexamenesService = new GenericService<TurnoExamen>();
        BindingSource listaTurnos = new BindingSource();
        public TurnoExamenesView()
        {
            InitializeComponent();
            dataGridTurnoExamenes.DataSource = listaTurnos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaTurnos.DataSource = await turnoexamenesService.GetAllAsync();
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var turnoexamenes = (TurnoExamen)listaTurnos.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Ciclo Lectivo {turnoexamenes.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await turnoexamenesService.DeleteAsync(turnoexamenes.Id);
                await CargarGrilla();
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarTurnoExamenesView agregarEditarTurnoExamenesView = new AgregarEditarTurnoExamenesView();
            agregarEditarTurnoExamenesView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {

            var turnoexamen = (TurnoExamen)listaTurnos.Current;
            if (turnoexamen == null)
            {
                MessageBox.Show("Debe seleccionar un valor de la grilla");
                return;
            }
            AgregarEditarTurnoExamenesView agregarEditarTurnoExamenesView = new AgregarEditarTurnoExamenesView(turnoexamen);
            agregarEditarTurnoExamenesView.ShowDialog();
            await CargarGrilla();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
