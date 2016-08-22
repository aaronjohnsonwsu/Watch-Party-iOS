using System;
using UIKit;

namespace WpApp.ViewControllers
{
    public partial class NearbyEventsController : UIViewController
    {
        public string FilterKeyword;

        public NearbyEventsController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}