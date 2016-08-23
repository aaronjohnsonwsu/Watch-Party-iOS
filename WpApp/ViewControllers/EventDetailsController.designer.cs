// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WpApp
{
    [Register ("EventDetailsController")]
    partial class EventDetailsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView TeamLogoImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TeamLogoImageView != null) {
                TeamLogoImageView.Dispose ();
                TeamLogoImageView = null;
            }
        }
    }
}