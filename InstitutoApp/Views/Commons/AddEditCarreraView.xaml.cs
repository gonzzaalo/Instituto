using InstitutoApp.ViewModels.Commons;
using InstitutoServices.Models.Commons;

namespace InstitutoApp.Views.Commons;

public partial class AddEditCarreraView : ContentPage
{
    AddEditCarreraViewModel viewModel;

	public AddEditCarreraView()
	{
		InitializeComponent();
	}
    public AddEditCarreraView(Carrera carrera)
    {
        InitializeComponent();
        viewModel = this.BindingContext as AddEditCarreraViewModel;
        viewModel.Carrera = carrera;
    }
}