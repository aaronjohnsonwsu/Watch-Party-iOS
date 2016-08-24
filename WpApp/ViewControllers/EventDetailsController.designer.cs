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

namespace WpApp.ViewControllers
{
    [Register ("EventDetailsController")]
    partial class EventDetailsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EventAttendingLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView EventLocationMapView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GameDateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LocationAddressLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LocationNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LocationPhoneNumberLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OpponentLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView OpponentTeamLogoImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView TeamLogoImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EventAttendingLabel != null) {
                EventAttendingLabel.Dispose ();
                EventAttendingLabel = null;
            }

            if (EventLocationMapView != null) {
                EventLocationMapView.Dispose ();
                EventLocationMapView = null;
            }

            if (GameDateLabel != null) {
                GameDateLabel.Dispose ();
                GameDateLabel = null;
            }

            if (LocationAddressLabel != null) {
                LocationAddressLabel.Dispose ();
                LocationAddressLabel = null;
            }

            if (LocationNameLabel != null) {
                LocationNameLabel.Dispose ();
                LocationNameLabel = null;
            }

            if (LocationPhoneNumberLabel != null) {
                LocationPhoneNumberLabel.Dispose ();
                LocationPhoneNumberLabel = null;
            }

            if (OpponentLabel != null) {
                OpponentLabel.Dispose ();
                OpponentLabel = null;
            }

            if (OpponentTeamLogoImageView != null) {
                OpponentTeamLogoImageView.Dispose ();
                OpponentTeamLogoImageView = null;
            }

            if (TeamLogoImageView != null) {
                TeamLogoImageView.Dispose ();
                TeamLogoImageView = null;
            }
        }
    }
}