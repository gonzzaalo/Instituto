using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Services;
using InstitutoDesktop.Util;
using InstitutoServices.Enums;
using InstitutoServices.Interfaces;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Interfaces.Horarios;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Services.Commons;
using InstitutoServices.Services.Horarios;
using System.Data;
using System.Diagnostics;

namespace InstitutoDesktop.Views
{
    public partial class CiclosLectivosView : Form
    {
        List<CicloLectivo>? listaCicloLectivos = new List<CicloLectivo>();
        CicloLectivo cicloLectivoCurrent;

        private readonly MemoryCacheServiceWinForms _memoryCache;

        public CiclosLectivosView(MemoryCacheServiceWinForms memoryCacheService, MenuPrincipalView menuPrincipal)
        {
            InitializeComponent();
            this.MdiParent = menuPrincipal;
            _memoryCache = memoryCacheService;
            LoadData();
            tabPageAgregarEditar.Enabled = false;


        }

        private async Task LoadData()
        {
            ShowInActivity.Show("Cargando ciclos lectivos...");
            listaCicloLectivos = await _memoryCache.GetAllCacheAsync<CicloLectivo>("CiclosLectivos");
            ShowInActivity.Hide();
            LoadGrid();
        }

        private async Task LoadGrid()
        {
            if (listaCicloLectivos != null && listaCicloLectivos.Count > 0)
                Grilla.DataSource = listaCicloLectivos.OrderBy(ciclo => ciclo.Nombre).ToList();
            Grilla.OcultarColumnas(new string[] { "Id", "Eliminado" });

        }
        private async Task LoadGridFilter()
        {
            if (listaCicloLectivos != null && listaCicloLectivos.Count > 0)
                Grilla.DataSource = listaCicloLectivos.Where(ciclo => ciclo.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).OrderBy(ciclo => ciclo.Nombre).ToList();
            Grilla.OcultarColumnas(new string[] { "Id", "Eliminado" });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabPageAgregarEditar.Enabled = true;
            tabPageLista.Enabled = false;
            tabControl.SelectTab(tabPageAgregarEditar);
            cicloLectivoCurrent = new CicloLectivo();
            ActualizarTabAgregarEditar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe definirse un nombre para el ciclo lectivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cicloLectivoCurrent.Nombre = txtNombre.Text;
            cicloLectivoCurrent.Actual = chkActual.Checked;




            if (cicloLectivoCurrent.Id == 0)
            {
                await _memoryCache.AddCacheAsync<CicloLectivo>(cicloLectivoCurrent, "CiclosLectivos");
                //await horarioService.AddAsync(horarioCurrent);
            }
            else
            {
                await _memoryCache.UpdateCacheAsync<CicloLectivo>(cicloLectivoCurrent, "CiclosLectivos");
            }

            await LoadGrid();
            tabControl.SelectTab(tabPageLista);
            tabPageAgregarEditar.Enabled = false;
            tabPageLista.Enabled = true;

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(Grilla.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un ciclo lectivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tabPageAgregarEditar.Enabled = true;
            tabPageLista.Enabled = false;

            cicloLectivoCurrent = (CicloLectivo)Grilla.CurrentRow.DataBoundItem;
            ActualizarTabAgregarEditar();
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private void ActualizarTabAgregarEditar()
        {
            txtNombre.Text = cicloLectivoCurrent.Nombre;
            chkActual.Checked = cicloLectivoCurrent.Actual;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            cicloLectivoCurrent = (CicloLectivo)Grilla.CurrentRow.DataBoundItem;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar el ciclo lectivo {cicloLectivoCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await _memoryCache.DeleteCacheAsync<CicloLectivo>(cicloLectivoCurrent.Id, "CiclosLectivos");
                await LoadGrid();
            }
            cicloLectivoCurrent = null;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActualizarTabAgregarEditar();
            cicloLectivoCurrent = null;
            tabControl.SelectTab(tabPageLista);
            tabPageAgregarEditar.Enabled = false;
            tabPageLista.Enabled = true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "")
            {
                LoadGrid();
            }
            else
            {
                LoadGridFilter();
            }
        }



        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }



        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grilla_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            btnModificar.Enabled = Grilla.Rows.Count > 0;
            btnEliminar.Enabled = Grilla.Rows.Count > 0;
        }
    }
}
