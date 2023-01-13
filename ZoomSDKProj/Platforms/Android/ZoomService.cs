using ZoomSDKProj.Interfaces;
using AndroidApp = Android.App.Application;
using US.Zoom.Sdk;

namespace ZoomSDKProj.Platforms.Services
{
    public class ZoomService : Java.Lang.Object, IZoomService, IZoomSDKInitializeListener
    {
        ZoomSDK zoomSDK;
        public ZoomService()
        {
        }

        public void InitZoomLib(string appKey, string appSecret)
        {
            zoomSDK = ZoomSDK.Instance;
            var zoomInitParams = new ZoomSDKInitParams
            {
                AppKey = appKey,
                AppSecret = appSecret,
            };
            zoomSDK.Initialize(AndroidApp.Context, this, zoomInitParams);
        }

        public bool IsInitialized() => zoomSDK?.IsInitialized ?? false;

        public void JoinMeeting(string meetingId, string displayName, string meetingPassword)
        {
            try
            {
                if (IsInitialized())
                {
                    var meetingService = zoomSDK.MeetingService;
                    meetingService.JoinMeetingWithParams(AndroidApp.Context, new JoinMeetingParams
                    {
                        MeetingNo = meetingId,
                        DisplayName = displayName,
                        Password = meetingPassword
                    });
                }
            }
            catch(Exception ex) { }
        }

        public void OnZoomAuthIdentityExpired()
        {

        }

        public void OnZoomSDKInitializeResult(int p0, int p1)
        {

        }
    }
}
