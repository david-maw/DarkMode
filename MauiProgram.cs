using Microsoft.Extensions.Logging;

namespace DarkMode;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        // In .NET11 opt-in to having Maui set the system bar colors on Android to match
        AppContext.SetSwitch(
            "MauiAndroidSystemBarsUseMauiChrome",
            true);

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
