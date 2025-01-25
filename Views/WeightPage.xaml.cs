using MauiPocketTrainer.ViewModels;

namespace MauiPocketTrainer.Views;

public partial class WeightPage : ContentPage
{
	public WeightPage()
	{
		InitializeComponent();
		BindingContext = new WeightViewModel();
	}
}