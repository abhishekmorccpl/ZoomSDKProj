namespace ZoomSDKProj;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		var window = base.CreateWindow(activationState);
		window.X = 0;
		window.Y = 0;
		window.Height = 1024;
		window.Width= 1280;

		return window;
    }
}
