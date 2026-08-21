namespace GuessingGame;

public partial class GuessingGamePage : ContentPage
{
	private int _numberToGuess;
	public GuessingGamePage(int minimum, int maximum)
	{
		InitializeComponent();

		Random random = new Random();

		random.Next(100);

		_numberToGuess = random.Next(minimum, maximum);

		FeedbackLabel.Text = $"Guess a number between {minimum} and {maximum}";

    }

    private void GuessButton_Clicked(object sender, EventArgs e)
    {
		int numberGuessed = int.Parse(GuessEntry.Text);
		if (_numberToGuess == numberGuessed)
		{
			FeedbackLabel.Text = "Well Done Olwe2! Correct Guess";
			FeedbackLabel.TextColor = Color.FromRgba(0, 128, 0, 128);

		}
		else if (numberGuessed > _numberToGuess)
		{
			FeedbackLabel.Text = "Too high";
			FeedbackLabel.TextColor = Color.FromRgba(255, 0, 0, 255);
		}
		else
		{
			FeedbackLabel.Text = "Too low";
			FeedbackLabel.TextColor = Color.FromRgba(255, 0, 0, 255);
		}
    }
}