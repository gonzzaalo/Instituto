using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
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
    public partial class AulasView : Form
    {

        IGenericService<Aula> aulaService = new GenericService<Aula>();
        BindingSource BindingAula = new BindingSource();
        List<Aula> listAula = new List<Aula>();
        public AulasView()
        {
            InitializeComponent();
            dataGridAulas.DataSource = BindingAula;
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de aulas");
            listAula = await aulaService.GetAllAsync();
            dataGridAulas.OcultarColumnas(new string[] { "Eliminado" });
            ShowInActivity.Hide();
            BindingAula.DataSource = listAula;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarAulaView agregarEditarAulaView = new AgregarEditarAulaView();
            agregarEditarAulaView.ShowDialog();
            CargarGrilla();
        }

        private async void iconEditar_Click(object sender, EventArgs e)
        {
            var aula = (Aula)BindingAula.Current;
            AgregarEditarAulaView agregarEditarAulaView = new AgregarEditarAulaView(aula);
            agregarEditarAulaView.ShowDialog();
           await CargarGrilla();
        }

        private async void iconEliminar_Click(object sender, EventArgs e)
        {

            var aula = (Aula)BindingAula.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el aula{aula.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await aulaService.DeleteAsync(aula.Id);
                await CargarGrilla();
                dataGridAulas.SeleccionarFilaNuevaOEditada(aula.Id);
            }
        }

        private void iconSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
