
using Firebase.Auth;
using Firebase.Auth.Providers;
using System.Net.Http.Json;

namespace InstitutoApp.Views.Login;

public partial class IniciarSesion : ContentPage
{
    private readonly string _clientId = Properties.Resources.client_id+ ".apps.googleusercontent.com";
    private readonly string _redirectUri = $"com.googleusercontent.apps.{Properties.Resources.client_id}:/oauth2redirect";
    private readonly string _authUri = "https://accounts.google.com/o/oauth2/v2/auth";
    private readonly string _tokenUri = "https://oauth2.googleapis.com/token";

    public IniciarSesion()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            var authUrl = $"{_authUri}?client_id={_clientId}&redirect_uri={_redirectUri}&response_type=code&scope=email%20profile&access_type=offline";

            // Abre el navegador para el inicio de sesi�n
            var authResult = await WebAuthenticator.AuthenticateAsync(
                new Uri(authUrl),
                new Uri(_redirectUri));

            // Obtener el c�digo de autorizaci�n
            var authCode = authResult.Properties["code"];

            // Intercambiar el c�digo por un token de acceso
            var idToken = await ExchangeAuthCodeForToken(authCode);

            // Iniciar sesi�n con Firebase usando el token de acceso
            //await SignInWithFirebase(accessToken);
            // Aqu� puedes manejar el token de acceso (guardar, usar para solicitar datos, etc.)
            try
            {

                // Paso 2: Intercambia el access token de Google por un token de Firebase
                var nameUser = await SignInWithGoogleAccessToken(idToken);

                // El usuario ha sido registrado correctamente en Firebase y obtienes el ID Token de Firebase
                Console.WriteLine($"Usuario registrado exitosamente en Firebase. Firebase Nombre usuario: {nameUser}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al registrar al usuario en Firebase: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            // Manejo de errores
            await DisplayAlert("Error", $"Ocurri� un error: {ex.Message}", "OK");
        }
    }

    // M�todo para intercambiar el c�digo de autorizaci�n por un token de acceso
    private async Task<string> ExchangeAuthCodeForToken(string authCode)
    {
        using (var client = new HttpClient())
        {
            var tokenRequest = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("code", authCode),
                new KeyValuePair<string, string>("client_id", _clientId),
                new KeyValuePair<string, string>("redirect_uri", _redirectUri),
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
            });

            var response = await client.PostAsync(_tokenUri, tokenRequest);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var tokenData = System.Text.Json.JsonDocument.Parse(jsonResponse).RootElement;

            return tokenData.GetProperty("id_token").GetString();
        }
    }

    // ...

    private readonly string _firebaseApiKey = Properties.Resources.apiKeyFirebase;

    // M�todo para registrar al usuario en Firebase usando el access token de Google
    public async Task<string> SignInWithGoogleAccessToken(string googleAccessToken)
    {
        var firebaseUrl = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithIdp?key={_firebaseApiKey}";

        var requestData = new
        {
            postBody = $"id_token={googleAccessToken}&providerId=google.com",
            requestUri = "http://localhost", // Este campo es necesario, pero no se usa
            returnSecureToken = true
        };

        using var httpClient = new HttpClient();
        var response = await httpClient.PostAsJsonAsync(firebaseUrl, requestData);

        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadFromJsonAsync<FirebaseSignInResponse>();
            return jsonResponse?.DisplayName; // Devuelve el ID Token de Firebase si el registro es exitoso
        }
        else
        {
            var errorResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Error al registrar el usuario: {errorResponse}");
            throw new HttpRequestException($"Error al registrar el usuario en Firebase: {response.ReasonPhrase}");
        }
        
    }
}
// Clase para deserializar la respuesta de Firebase
public class FirebaseSignInResponse
{
    public string IdToken { get; set; }
    public string RefreshToken { get; set; }
    public string LocalId { get; set; }
    public string Email { get; set; }
    public bool EmailVerified { get; set; }
    public string DisplayName { get; set; }
}

