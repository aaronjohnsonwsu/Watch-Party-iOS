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
    [Register ("TeamTableViewCell")]
    partial class TeamTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView OpponentImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OpponentLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView TeamLogoImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TeamNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (OpponentImageView != null) {
                OpponentImageView.Dispose ();
                OpponentImageView = null;
            }

            if (OpponentLabel != null) {
                OpponentLabel.Dispose ();
                OpponentLabel = null;
            }

            if (TeamLogoImageView != null) {
                TeamLogoImageView.Dispose ();
                TeamLogoImageView = null;
            }

            if (TeamNameLabel != null) {
                TeamNameLabel.Dispose ();
                TeamNameLabel = null;
            }
        }
    }
}