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
        UIKit.UIButton CreateEventButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView EventLocationMapView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GameDateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HomeAwayLabel { get; set; }

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
        UIKit.UIImageView OpponentTeamLogoImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView TeamLogoImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CreateEventButton != null) {
                CreateEventButton.Dispose ();
                CreateEventButton = null;
            }

            if (EventLocationMapView != null) {
                EventLocationMapView.Dispose ();
                EventLocationMapView = null;
            }

            if (GameDateLabel != null) {
                GameDateLabel.Dispose ();
                GameDateLabel = null;
            }

            if (HomeAwayLabel != null) {
                HomeAwayLabel.Dispose ();
                HomeAwayLabel = null;
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