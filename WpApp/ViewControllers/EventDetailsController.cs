using Foundation;
using System;
using CoreLocation;
using MapKit;
using UIKit;
using WpApp.Core.Models;
using WpApp.Core.Services;

namespace WpApp
{
    public partial class EventDetailsController : UIViewController
    {
        public string PlaceId { get; set; }
        private readonly GooglePlaceSearchApi _googlePlaceService = new GooglePlaceSearchApi();
        private WatchPartyApi _watchPartyService = new WatchPartyApi();
        public GoogleLocation SelectedEventLocation;
        public Team SelectedTeam;
        public Game SelectedGame;

        public EventDetailsController (IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            SelectedEventLocation = await _googlePlaceService.FindPlacesById(PlaceId);
            this.LocationNameLabel.Text = SelectedEventLocation.Name;
            this.LocationAddressLabel.Text = SelectedEventLocation.Address;
            this.LocationPhoneNumberLabel.Text = SelectedEventLocation.PhoneNumber;
            this.TeamLogoImageView.Image = FromUrl(SelectedTeam.Icon);
            this.OpponentTeamLogoImageView.Image = FromUrl(SelectedGame.OpponentLogo);
            this.GameDateLabel.Text = SelectedGame.GameDate;
            this.HomeAwayLabel.Text = SelectedGame.Opponent.Contains("@") ? "@" : "VS";

            if (SelectedEventLocation.Latitude != null && SelectedEventLocation.Longitude != null)
            {
                var span = new MKCoordinateSpan(MilesToLatitudeDegrees(1), MilesToLongitudeDegrees(1, SelectedEventLocation.Latitude.Value));
                this.EventLocationMapView.Region = new MKCoordinateRegion(new CLLocationCoordinate2D(SelectedEventLocation.Latitude.Value, SelectedEventLocation.Longitude.Value), span);
                this.EventLocationMapView.MapType = MKMapType.Standard;
                this.EventLocationMapView.AddAnnotation(new MKPointAnnotation()
                {
                    Coordinate = new CLLocationCoordinate2D(SelectedEventLocation.Latitude.Value, SelectedEventLocation.Longitude.Value),
                    Title = SelectedEventLocation.Name
                });

            }

            this.CreateEventButton.TouchUpInside += delegate
            {
                var evnt = new Event()
                {
                    Id = Guid.NewGuid().ToString(),
                    CreatedByUserId = "007b4f09-d4da-4x41-be3a-8e45fc0a572c",
                    DateAdded = DateTime.Now,
                    GameId = SelectedGame.Id,
                    GooglePlaceId = SelectedEventLocation.PlaceId,
                    IsCancelled = false,
                    NumberAttending = 1,
                    TeamId = SelectedTeam.Id,
                };

                _watchPartyService.AddEvent(evnt);
            };
        }

        public double MilesToLatitudeDegrees(double miles)
        {
            double earthRadius = 3960.0; // in miles
            double radiansToDegrees = 180.0 / Math.PI;
            return (miles / earthRadius) * radiansToDegrees;
        }

        public double MilesToLongitudeDegrees(double miles, double atLatitude)
        {
            double earthRadius = 3960.0; // in miles
            double degreesToRadians = Math.PI / 180.0;
            double radiansToDegrees = 180.0 / Math.PI;
            // derive the earth's radius at that point in latitude
            double radiusAtLatitude = earthRadius * Math.Cos(atLatitude * degreesToRadians);
            return (miles / radiusAtLatitude) * radiansToDegrees;
        }

        static UIImage FromUrl(string uri)
        {
            using (var url = new NSUrl(uri))
            {
                using (var data = NSData.FromUrl(url))
                {
                    return UIImage.LoadFromData(data);
                }
            }
        }
    }
}