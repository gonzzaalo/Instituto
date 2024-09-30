using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace InstitutoWeb.Services.Login
{
    public class FirebaseAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string UserIdKey = "firebaseUserId";
        public event Action OnChangeLogin;

        public FirebaseAuthService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<string> SignInWithEmailPassword(string email, string password, bool rememberPassword)
        {
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.signInWithEmailPassword", email, password);
            if (userId != null)
            {
                if (rememberPassword)
                {
                    await _jsRuntime.InvokeVoidAsync("localStorageHelper.setItem", UserIdKey, userId);
                }
                else
                {
                    await _jsRuntime.InvokeVoidAsync("sesionStorageHelper.setItem", UserIdKey, userId);
                }
                OnChangeLogin?.Invoke();
            }
            return userId;
        }

        public async Task<string> createUserWithEmailAndPassword(string email, string password)
        {
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.createUserWithEmailAndPassword", email, password);
            return userId;
        }

        public async Task SignOut()
        {
            await _jsRuntime.InvokeVoidAsync("firebaseAuth.signOut");
            await _jsRuntime.InvokeVoidAsync("localStorageHelper.removeItem", UserIdKey);
            await _jsRuntime.InvokeVoidAsync("sesionStorageHelper.removeItem", UserIdKey);
            OnChangeLogin?.Invoke();
        }


        public async Task<string> GetUserIdInLocalStorage()
        {
            return await _jsRuntime.InvokeAsync<string>("localStorageHelper.getItem", UserIdKey);
        }
        public async Task<string> GetUserIdInSesionStorage()
        {
            return await _jsRuntime.InvokeAsync<string>("sesionStorageHelper.getItem", UserIdKey);
        }

        public async Task<bool> IsUserAuthenticated()
        {
            var userId = await GetUserIdInLocalStorage();
            if (string.IsNullOrEmpty(userId))
            {
                userId = await GetUserIdInSesionStorage();
            }
            return !string.IsNullOrEmpty(userId);
        }
    }
}
