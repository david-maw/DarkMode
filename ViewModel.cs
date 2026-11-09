namespace DarkMode;

internal class ViewModel
{
    public bool Dark
    {
        set
        {
            if (value != Dark)
                App.Current?.UserAppTheme = value ? AppTheme.Dark : AppTheme.Light;
        }
        get => App.Current?.UserAppTheme == AppTheme.Dark || App.Current?.RequestedTheme == AppTheme.Dark;
    }
}
