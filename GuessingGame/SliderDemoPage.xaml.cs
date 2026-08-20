//using Xamarin.Google.Crypto.Tink.Shaded.Protobuf;

namespace GuessingGame;

public partial class SliderDemoPage : ContentPage
{
	public SliderDemoPage()
	{
		InitializeComponent();
		DemoSlider.Minimum = 1;
		DemoSlider.Maximum = 360;
		//DemoSlider.Rotation = 90;
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		var value = Math.Round(e.NewValue, 2);

        SliderValueLabel.Text = value.ToString();
		SliderValueLabel.FontSize = value;

		SlideMeLabel.Rotation = value;

	}
}