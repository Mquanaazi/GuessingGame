using Android.App;
using Android.Runtime;
using Microsoft.Maui.Platform;

namespace GuessingGame
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        //protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
        protected override MauiApp CreateMauiApp()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (h, v) =>
            {
                h.PlatformView.BackgroundTintList =
                Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            });
            return MauiProgram.CreateMauiApp();
        }
        


    }
}
