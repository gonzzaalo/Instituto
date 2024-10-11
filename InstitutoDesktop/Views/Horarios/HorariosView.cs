using InstitutoServices.Interfaces;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Interfaces.Horarios;
using InstitutoServices.Models;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Services;
using InstitutoServices.Services.Commons;
using InstitutoServices.Services.Horarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views
{
    public partial class HorariosView : Form
    {
        IHorarioService horarioService = new HorarioService();
        IGenericService<CicloLectivo> cicloLectivoService = new GenericService<CicloLectivo>();
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();
        IAnioCarreraService anioCarreraService = new AnioCarreraService();
        BindingSource listaHorarios = new BindingSource();
        List<CicloLectivo>? listaCicloLectivos = new List<CicloLectivo>();
        List<Carrera>? listaCarreras = new List<Carrera>();
        List<AnioCarrera>? listaAnioCarreras = new List<AnioCarrera>();
        Horario horarioCurrent;

        public HorariosView()
        {
            InitializeComponent();
            dataGridHorarios.DataSource = listaHorarios;
            ObtenerListas();
            
            CargarGrilla();
        }

        private void CargarCombos()
        {
            cboCiclosLectivos.DataSource = listaCicloLectivos.ToList();
            cboCiclosLectivos.DisplayMember = "Nombre";
            cboCiclosLectivos.ValueMember = "Id";

            cboCarreras.DataSource = listaCarreras.ToList();
            cboCarreras.DisplayMember = "Nombre";
            cboCarreras.ValueMember = "Id";

            cboAniosCarreras.DataSource = listaAnioCarreras.Where(a => a.Carrera.Equals((int)cboCarreras.SelectedValue)).ToList();
        }

        private async void ObtenerListas()
        {
            listaCicloLectivos =(List<CicloLectivo>) await cicloLectivoService.GetAllAsync();
            listaCarreras = (List<Carrera>)await carreraService.GetAllAsync();
            listaAnioCarreras = (List<AnioCarrera>)await anioCarreraService.GetAllAsync();
            CargarCombos();
        }

        private async Task CargarGrilla()
        {
            listaHorarios.DataSource = await horarioService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (horarioCurrent != null)
            {
                //horarioCurrent.Nombre = txtNombre.Text;
                await horarioService.UpdateAsync(horarioCurrent);
                horarioCurrent = null;
            }
            else
            {
                var horario = new Horario
                {
                    //Nombre = txtNombre.Text
                };
                await horarioService.AddAsync(horario);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            horarioCurrent = (Horario)listaHorarios.Current;
            //txtNombre.Text = localidadCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            horarioCurrent = (Horario)listaHorarios.Current;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar el horario de {horarioCurrent.Materia.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await horarioService.DeleteAsync(horarioCurrent.Id);
                await CargarGrilla();
            }
            horarioCurrent = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            horarioCurrent = null;
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }



        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedValue == null && cboCarreras.SelectedValue.GetType()==typeof(int))
            {
                cboAniosCarreras.DataSource = listaAnioCarreras.Where(a => a.Carrera.Equals(cboCarreras.SelectedValue)).ToList();
            }
        }
    }
}
