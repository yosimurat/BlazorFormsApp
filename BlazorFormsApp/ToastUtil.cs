//using Microsoft.Windows.AppNotifications;
//using Microsoft.Windows.AppNotifications.Builder;

using Microsoft.Toolkit.Uwp.Notifications;

namespace BlazorFormsApp
{
    class ToastUtil
    {
        public static void Toast(string toastMsg, string toastTitle)
        {
            new ToastContentBuilder()
                 .AddText(toastTitle)
                 .AddText(toastMsg)
                 .Show();

        }
    }
}
