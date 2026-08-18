using Microsoft.Extensions.DependencyInjection;

namespace GuessingGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();// converts xml to c# compatible , allows .net to run xml content 
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new GuessingGamePage(0,100));
        }
    }
}