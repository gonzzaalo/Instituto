using InstitutoServices.Services;
using InstitutoDesktop.Views.Commons;
using InstitutoServices.Interfaces;
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

namespace InstitutoDesktop.Views.Commons.Alumnos
{
    public partial class AlumnosView : Form
    {
        IGenericService<Alumno> alumnoService = new GenericService<Alumno>();
        BindingSource listaAlumnos=new BindingSource();

        public AlumnosView()
        {
            InitializeComponent();
            dataGridAlumnos.DataSource = listaAlumnos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaAlumnos.DataSource = await alumnoService.GetAllAsync();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarAlumnosView agregarEditarAlumnosView = new AgregarEditarAlumnosView();
            agregarEditarAlumnosView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var alumno = (Alumno)listaAlumnos.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a el alumno {alumno.ApellidoNombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await alumnoService.DeleteAsync(alumno.Id);
                await CargarGrilla();
            }
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var alumno = (Alumno)listaAlumnos.Current;
            AgregarEditarAlumnosView agregarEditarAlumnosView = new AgregarEditarAlumnosView(alumno);
            agregarEditarAlumnosView.ShowDialog();
            await CargarGrilla();
        }
    }
}
