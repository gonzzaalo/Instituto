using InstitutoDesktop.ExtensionMethods;
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

namespace InstitutoDesktop.Views.Commons
{
    public partial class DocentesView : Form
    {
        IGenericService<Docente> docenteService = new GenericService<Docente>();
        BindingSource ListaDocente = new BindingSource();

        public DocentesView()
        {
            InitializeComponent();
            dataGridDocentes.DataSource = ListaDocente;
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            ListaDocente.DataSource = await docenteService.GetAllAsync();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarDocenteView agregarEditarDocenteView = new AgregarEditarDocenteView();
            agregarEditarDocenteView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var docente = (Docente)ListaDocente.Current;
            AgregarEditarDocenteView agregarEditarDocenteView = new AgregarEditarDocenteView(docente);
            agregarEditarDocenteView.ShowDialog();
            await CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var docente = (Docente)ListaDocente.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el docente{docente.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await docenteService.DeleteAsync(docente.Id);
                await CargarGrilla();
                dataGridDocentes.SeleccionarFilaNuevaOEditada(docente.Id);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
