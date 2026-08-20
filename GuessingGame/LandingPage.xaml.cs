namespace GuessingGame;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
	await Navigation.PushAsync(new GuessingGamePage(1, 10));
    }
}