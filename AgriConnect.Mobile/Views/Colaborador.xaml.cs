using AgriConnect.Mobile.ViewModel;

namespace AgriConnect.Mobile.Views;

public partial class Colaborador : ContentPage
{
	public Colaborador()
	{
		App.Current.Services.GetRequiredService<ColaboradorViewModel>();
        InitializeComponent();
    }
}