using ZoomSDKProj.Interfaces;
using ZoomSDKProj.Platforms.Services;
using System;
using System.Windows.Input;

namespace SampleZoom.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand JoinMeetingCommand { get; set; }
        public string MeetingId { get; set; }
        public string MeetingPassword { get; set; }
        IZoomService zoomService;

        public MainPageViewModel()
        {
            try
            {
                DependencyService.Register<IZoomService, ZoomService>();
                zoomService = DependencyService.Get<IZoomService>();
                zoomService.InitZoomLib("1ZfOLT7iNTDmbuQKe8YuIauvMtZ3K0l6gliX", "D8rsPtIanjpTCFnNLCyuaCBBCMy2xUq4KCaZ");
                JoinMeetingCommand = new Command(JoinMeeting);
            }
            catch(Exception ex) 
            {

            }
        }

        private void JoinMeeting()
        {
            if (!zoomService.IsInitialized())
            {
                return;
            }
            zoomService.JoinMeeting(MeetingId, "ZoomSample", MeetingPassword);
        }
    }
}
