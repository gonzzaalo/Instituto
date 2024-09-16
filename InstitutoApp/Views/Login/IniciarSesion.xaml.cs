using System.Text.Json;
using System.Text.Json.Serialization;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util.Store;

namespace InstitutoApp.Views.Login;

public partial class IniciarSesion : ContentPage
{
    private readonly string _clientId = Properties.Resources.client_id;

    private readonly string _clientSecret = "your_client_secret";
    private readonly string _redirectUri = "com.isp20.institutoapp:/oauth2redirect";

    public IniciarSesion()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Definimos la URL de autenticación con OAuth2
            var authUrl = new Uri($"https://accounts.google.com/o/oauth2/v2/auth?" +
                                  $"client_id={_clientId}&" +
                                  "response_type=code&" +
                                  "scope=openid%20profile%20email&" +
                                  $"redirect_uri={_redirectUri}");

            // URL de redirección, usando el nuevo esquema recomendado
            var callbackUrl = new Uri(_redirectUri);

            // Llamada a WebAuthenticator para manejar el flujo OAuth
            var result = await WebAuthenticator.Default.AuthenticateAsync(authUrl, callbackUrl);

            // Extraemos el código de autorización recibido
            var authorizationCode = result?.Properties["code"];

            // Intercambiamos el código de autorización por un token de acceso
            var accessToken = await ExchangeCodeForToken(authorizationCode);

            // Aquí puedes manejar el token de acceso (guardar, usar para solicitar datos, etc.)
            await DisplayAlert("Login", $"se conectó correctamente el access token es {accessToken}", "OK");
        }
        catch (Exception ex)
        {
            // Manejo de errores
            await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
        }
    }

    private async Task<string> ExchangeCodeForToken(string authCode)
    {
        var httpClient = new HttpClient();
        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "code", authCode },
            { "client_id", _clientId },
            { "client_secret", _clientSecret },
            { "redirect_uri", _redirectUri },
            { "grant_type", "authorization_code" }
        });

        var response = await httpClient.PostAsync("https://oauth2.googleapis.com/token", content);
        var jsonResponse = await response.Content.ReadAsStringAsync();

        var tokenResponse = JsonSerializer.Deserialize<OAuthTokenResponse>(jsonResponse);
        return tokenResponse.AccessToken;
    }
    //Método para intercambiar el código de autorización por un token de acceso
    //private async Task<string> ExchangeAuthorizationCodeForTokenAsync(string authorizationCode)
    //{
    //    var tokenRequestUrl = "https://oauth2.googleapis.com/token";
    //    var requestData = new Dictionary<string, string>
    //        {
    //            { "client_id", _clientId },
    //            { "client_secret", _clientSecret },
    //            { "code", authorizationCode },
    //            { "grant_type", "authorization_code" },
    //            { "redirect_uri", _redirectUri }
    //        };

    //    var content = new FormUrlEncodedContent(requestData);
    //    var response = await new HttpClient().PostAsync(tokenRequestUrl, content);
    //    var responseContent = await response.Content.ReadAsStringAsync();

    //    // Procesamos la respuesta JSON para obtener el token de acceso
    //    var json = JsonDocument.Parse(responseContent);
    //    return json.RootElement.GetProperty("access_token").GetString();
    //}

    public class OAuthTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
    //private async Task<string> ExchangeAuthorizationCodeForTokenAsync(string authorizationCode)
    //{
    //    var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
    //    {
    //        ClientSecrets = new ClientSecrets
    //        {
    //            ClientId = _clientId,
    //            ClientSecret = _clientSecret
    //        },
    //        Scopes = new[] { "openid", "profile", "email" },
    //        DataStore = new FileDataStore("Tokens") // Almacena los tokens en un archivo local
    //    });

    //    var tokenResponse = await flow.ExchangeCodeForTokenAsync(_clientId, authorizationCode,_redirectUri, CancellationToken.None);

    //    return tokenResponse.AccessToken;
    //}
}