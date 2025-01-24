using MauiPocketTrainer.ViewModels;

namespace MauiPocketTrainer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Uzyskanie WeightViewModel z DI poprzez MauiApp
            var viewModel = (WeightViewModel)Application.Current!.Handler.MauiContext.Services.GetService(typeof(WeightViewModel));

            if (viewModel != null)
            {
                BindingContext = viewModel;
            }
            else
            {
                // Obsługa przypadku, kiedy viewModel nie jest dostępny
                Console.WriteLine("WeightViewModel not found in DI container.");
            }
        }
    }


}
