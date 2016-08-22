// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;

namespace WpApp.ViewControllers
{
    [Register ("NearbyEventsController")]
    partial class NearbyEventsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView NearbyEventsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NearbyEventsTableView != null) {
                NearbyEventsTableView.Dispose ();
                NearbyEventsTableView = null;
            }
        }
    }
}