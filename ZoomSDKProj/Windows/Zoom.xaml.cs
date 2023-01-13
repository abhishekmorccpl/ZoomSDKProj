using SampleZoom.ViewModels;

namespace ZoomSDKProj.Windows;

public partial class Zoom : ContentPage
{
    int callZoomCount = 0;
    bool IsZoomcalled = false;
    private Window _window;

    public Zoom()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();

    }

    private void ZoomPage_Loaded(object sender, EventArgs e)
    {
       
    }

    //private void CallZoom(string strMeetingID, string strPassword)
    //{
    //    callZoomCount++;

    //    if (callZoomCount > 1)
    //    {
    //        try
    //        {
    //            System.Threading.Thread.Sleep(10000);
    //        }
    //        catch (Exception ex)
    //        {

    //        }

    //        //Log.Information("CallZoom - Count - " + callZoomCount.ToString());
    //    }

    //    try
    //    {
    //        //Log.Information("CallZoom() - Inside CallZoom");
    //        CheckVisible("Zoom");
    //        //Zoom Initialize
    //        ICredentialsService credentialsService = new CredentialsService(strMeetingID, strPassword);
    //        IZoomService zoomService = new ZoomService();

    //        //Patient Window calling                

    //        //Log.Information("CallZoom() - Before mainViewModel");
    //        mainViewModel = new MainViewModel(zoomService, credentialsService);
    //        //Log.Information("CallZoom() - After mainViewModel");
    //        IsZoomcalled = true;
    //        //Log.Information("CallZoom() - Before SetWindowHandle");

    //        SetWindowHandle();
    //        //Log.Information("CallZoom() - After SetWindowHandle");

    //        //Log.Information("CallZoom() - Before SetVideoContainerPosition");
    //        SetVideoContainerPosition();
    //        //Log.Information("CallZoom() - After SetVideoContainerPosition");
    //    }
    //    catch (Exception ex)
    //    {
    //        //Log.Error("CallZoom() Exception - " + ex.Message);
    //    }
    //}

    //private void CheckVisible(String div)
    //{
    //    string imgURL = string.Empty;

    //    if (div == "Zoom")
    //    {
    //        dpHome.Visibility = Visibility.Collapsed;
    //        dpTeleconsult.Visibility = Visibility.Visible;
    //        tbHeader.Text = "Zoom Call";
    //    }

    //}

    //private MainViewModel _mainViewModel;

    //public MainViewModel mainViewModel
    //{
    //    get => this._mainViewModel;
    //    set
    //    {
    //        this._mainViewModel = value;
    //        this.OnPropertyChanged(nameof(mainViewModel));
    //    }
    //}

    //private void LeaveZoom()
    //{
    //    try
    //    {
    //        if (IsZoomcalled == true)
    //        {
    //            mainViewModel.Leave();
    //            IsZoomcalled = false;
    //            CheckVisible("Home");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        //Log.Error("LeaveZoom() Exception - " + ex.Message);
    //    }
    //}

    //private void SetWindowHandle()
    //{
    //    try
    //    {
    //        if ((_window != null) && (mainViewModel != null))
    //        {
    //            var windowHandle = new WindowInteropHelper(_window).EnsureHandle();
    //            mainViewModel.ZoomHost.SetWindowHandle(windowHandle);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        //Log.Error("SetWindowHandle() Exception - " + ex.Message);
    //    }
    //}

    ////private void VideoContainerBorder_SizeChanged(object sender, SizeChangedEventArgs e)
    ////{
    ////    SetVideoContainerPosition();
    ////}

    ////Zoom calling biniding Position to this Border width and height
    //private void SetVideoContainerPosition()
    //{
    //    try
    //    {
    //        var videoContainerRect = BoundsRelativeTo(VideoContainerBorder, _window);

    //        if (mainViewModel != null)
    //            mainViewModel.ZoomHost.SetVideoContainerPosition(videoContainerRect);
    //    }
    //    catch (Exception ex)
    //    {
    //        //Log.Error("SetVideoContainerPosition() Exception - " + ex.Message);
    //    }
    //}

    //private Rect BoundsRelativeTo(UIElement element, UIElement relativeTo)
    //{
    //    var topLeft = element.TranslatePoint(new System.Windows.Point(0, 0), relativeTo);
    //    var bottomRight = element.TranslatePoint(new System.Windows.Point(element.RenderSize.Width, element.RenderSize.Height),
    //        relativeTo);

    //    return new Rect(topLeft, bottomRight);
    //}
}