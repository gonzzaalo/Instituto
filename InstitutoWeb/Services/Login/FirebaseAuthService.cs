using InstitutoServices.Models.Login;
using Microsoft.JSInterop;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

namespace InstitutoWeb.Services.Login
{
    public class FirebaseAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string UserFirebase = "firebaseUser";
        public event Action OnChangeLogin;

        public FirebaseAuthService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<FirebaseUser> LoginWithGoogle()
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithGoogle");

            if (user != null)
            {
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<FirebaseUser> LoginWithFacebook()
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithFacebook");

            if (user != null)
            {
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<LoginResponse> SignInWithEmailPassword(string email, string password, bool rememberPassword)
        {

            var response = await _jsRuntime.InvokeAsync<LoginResponse>("firebaseAuth.signInWithEmailPassword", email, password, rememberPassword);
            OnChangeLogin?.Invoke();

            return response;

        }

        public async Task<string> createUserWithEmailAndPassword(string email, string password, string displayName)
        {
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.createUserWithEmailAndPassword", email, password, displayName);
            return userId;
        }

        public async Task SignOut()
        {
            await _jsRuntime.InvokeVoidAsync("firebaseAuth.signOut");
            OnChangeLogin?.Invoke();
        }


        public async Task<FirebaseUser?> GetUserAuthenticated()
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.getUserFirebase");
            //chequeo que el usuario haya verificado su correo
            if (user != null && user.EmailVerified)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> SendPasswordResetEmail(string email)
        {
            return await _jsRuntime.InvokeAsync<bool>("firebaseAuth.sendPasswordResetEmail", email);
        }

    }
}