using System;
using CoreLocation;
using MapKit;
using UIKit;
using WpApp.Core.Models;
using WpApp.Core.Services;
using WpApp.Helpers;

namespace WpApp.ViewControllers
{
    public partial class EventDetailsController : UIViewController
    {
        private readonly GooglePlaceSearchService _googlePlaceService = new GooglePlaceSearchService();
        private readonly WatchPartyService _watchPartyService = new WatchPartyService();
        public GoogleLocation SelectedEventLocation;
        public Event SelectedEvent;

        public EventDetailsController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SelectedEventLocation = _googlePlaceService.FindPlacesById(SelectedEvent.GooglePlaceId);
            this.LocationNameLabel.Text = SelectedEventLocation.Name;
            this.LocationAddressLabel.Text = SelectedEventLocation.Address;
            this.LocationPhoneNumberLabel.Text = SelectedEventLocation.PhoneNumber;
            this.TeamLogoImageView.Image = Common.FromUrl(SelectedEvent.Team.Icon);
            this.OpponentTeamLogoImageView.Image = Common.FromUrl(SelectedEvent.Game.OpponentLogo);
            this.GameDateLabel.Text = SelectedEvent.Game.GameDate;
            this.OpponentLabel.Text = SelectedEvent.Game.Opponent;

            if (SelectedEventLocation.Latitude != null && SelectedEventLocation.Longitude != null)
            {
                var span = new MKCoordinateSpan(Common.MilesToLatitudeDegrees(1), Common.MilesToLongitudeDegrees(1, SelectedEventLocation.Latitude.Value));
                this.EventLocationMapView.Region = new MKCoordinateRegion(new CLLocationCoordinate2D(SelectedEventLocation.Latitude.Value, SelectedEventLocation.Longitude.Value), span);
                this.EventLocationMapView.MapType = MKMapType.Standard;
                this.EventLocationMapView.AddAnnotation(new MKPointAnnotation()
                {
                    Coordinate = new CLLocationCoordinate2D(SelectedEventLocation.Latitude.Value, SelectedEventLocation.Longitude.Value),
                    Title = SelectedEventLocation.Name
                });

            }


        }
    }
}