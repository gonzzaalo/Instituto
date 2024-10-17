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
        IGenericService<Aula> aulaService = new GenericService<Aula>();
        private Aula aula;
        public AgregarEditarAulaView()
        {
            InitializeComponent();
            aula = new Aula();
        }

        public AgregarEditarAulaView(Aula aula)
        {
            InitializeComponent();
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
                await aulaService.AddAsync(aula);
            }
            else
            {
                await aulaService.UpdateAsync(aula);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

