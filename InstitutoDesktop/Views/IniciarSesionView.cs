using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// main namespaces
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace InstitutoDesktop.Views
{
    public partial class IniciarSesionView : Form
    {
        FirebaseAuthClient firebaseAuthClient;
        public bool loginSuccessfull { get; set; } = false;

        public IniciarSesionView()
        {
            InitializeComponent();
            ConfiguracionFirebase();
        }

        private void ConfiguracionFirebase()
        {


            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBosVc8LN9yjnEbxF66g8UhbGsxu3so9H8",
                AuthDomain = "instituto20.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    // Add and configure individual providers
                    new EmailProvider()
                    // ...
                },

            };

            // ...and create your FirebaseAuthClient
            firebaseAuthClient = new FirebaseAuthClient(config);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            firebaseAuthClient.SignInWithEmailAndPasswordAsync(txtEmail.Text, txtPassword.Text).ContinueWith(task =>
            {
                if (task.IsFaulted)
                {
                    MessageBox.Show("Email o password incorrecto, intentelo nuevamente");
                }
                else
                {
                    loginSuccessfull = true;
                    this.Invoke(new Action(() => this.Close()));
                }
            });

        }

        private void chkVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkVerContraseña.Checked ? '\0' : '*';
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
