using InstitutoServices.Interfaces;
using InstitutoServices.Services;
using InstitutoDesktop.Views.Commons;
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
using InstitutoServices.Models.Inscripciones;

namespace InstitutoDesktop.Views.Inscripciones
{


    public partial class CiclosLectivosView : Form
    {
        IGenericService<CicloLectivo> ciclolectivoService = new GenericService<CicloLectivo>();
        BindingSource listaCicloLectivos = new BindingSource();
        public CiclosLectivosView()
        {
            InitializeComponent();
            dataGridCiclosLectivos.DataSource = listaCicloLectivos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaCicloLectivos.DataSource = await ciclolectivoService.GetAllAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = new AgregarEditarCicloLectivoView();
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var ciclolectivo = (CicloLectivo)listaCicloLectivos.Current;
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = new AgregarEditarCicloLectivoView(ciclolectivo);
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var ciclolectivo = (CicloLectivo)listaCicloLectivos.Current;
          
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Ciclo Lectivo {ciclolectivo.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await ciclolectivoService.DeleteAsync(ciclolectivo.Id);
                await CargarGrilla();
            }
        }
    }
}
