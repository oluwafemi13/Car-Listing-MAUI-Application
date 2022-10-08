using Car_Listing_MAUI_Application.ViewModel;

namespace Car_Listing_MAUI_Application;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(CarListViewModel carViewModel)
	{
		InitializeComponent();
		BindingContext = carViewModel;
	}

	/*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/
}

