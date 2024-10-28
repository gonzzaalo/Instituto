using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using InstitutoWeb;
using InstitutoWeb.Services;
using CurrieTechnologies.Razor.SweetAlert2;
using InstitutoServices.Services.Commons;
using InstitutoServices.Interfaces;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Interfaces.Inscripciones;
using InstitutoServices.Interfaces.Horarios;
using InstitutoServices.Services.Horarios;
using InstitutoServices.Interfaces.MesasExamenes;
using InstitutoWeb.Services.Login;
using InstitutoServices.Services.MesasExamenes;
using InstitutoServices.Services.Inscripciones;
using InstitutoWeb.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Logging.SetMinimumLevel(LogLevel.Debug);
string urlApi = builder.Configuration.GetValue<string>("UrlApiLocal");
if (builder.Configuration.GetValue<bool>("Remoto")==true)
     urlApi = builder.Configuration.GetValue<string>("UrlApiRemoto");

builder.Services.AddMemoryCache();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlApi) });
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IAnioCarreraService, AnioCarreraService>();
builder.Services.AddScoped<IMateriaService, MateriaService>();
builder.Services.AddScoped<IDetalleInscripcionService, DetalleInscripcionService>();
builder.Services.AddScoped<IMesaExamenService, MesaExamenService>();
builder.Services.AddScoped<IHorarioService, HorarioService>();
builder.Services.AddScoped<IDetalleHorarioService, DetalleHorarioService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<UsuarioService>(); // Añade esta línea

builder.Services.AddScoped<IInscriptoCarreraService, InscriptoCarreraService>();
builder.Services.AddScoped<IJefaturaSeccionService, JefaturaSeccionService>();
builder.Services.AddSingleton<IUsuarioStateService, UsuarioStateService>();
builder.Services.AddSingleton<IMemoryCacheService, MemoryCacheService>();
builder.Services.AddScoped<AuthenticationService>();


builder.Services.AddSweetAlert2();
AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
{
    var exception = eventArgs.ExceptionObject as Exception;
    // Aquí puedes personalizar el mensaje o registrar la excepción
    Console.WriteLine($"Excepción no manejada: {exception?.Message}");
};
await builder.Build().RunAsync();
