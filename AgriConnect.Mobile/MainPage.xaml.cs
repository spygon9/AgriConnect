using AgriConnect.Mobile.ViewModel;

namespace AgriConnect.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = App.Current.Services.GetRequiredService<ViewModelTest>();
            InitializeComponent();
        }

        //private async void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //    await Navigation.PushModalAsync(new Pages.TestPage());
        //    //await Navigation.PopAsync();
        //}
    }

}
