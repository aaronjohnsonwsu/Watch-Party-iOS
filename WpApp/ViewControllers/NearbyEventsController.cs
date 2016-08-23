using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AVFoundation;
using Foundation;
using UIKit;
using WpApp.Core.Models;
using WpApp.Core.Services;
using WpApp.Helpers;
using WpApp.TableCells;

namespace WpApp.ViewControllers
{
    public partial class NearbyEventsController : UIViewController, IUITableViewDataSource
    {
        private List<Event> _events;
        private readonly WatchPartyService _watchPartyService = new WatchPartyService();
        private readonly GooglePlaceSearchService _googlePlaceService = new GooglePlaceSearchService();

        public string FilterKeyword;

        public NearbyEventsController (IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            _events = await _watchPartyService.GetNearbyEvents();

            NearbyEventsTableView.WeakDataSource = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return (nint)_events.Count;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (NearbyEventTableViewCell)tableView.DequeueReusableCell("NearbyEventCell", indexPath);

            var currentEvent = _events[indexPath.Row];
            var location = _googlePlaceService.FindPlacesById(currentEvent.GooglePlaceId);

            cell.LocationName.Text = location.Name;
            cell.GameTitle.Text = currentEvent.Game.Team.Name + currentEvent.Game.Opponent;
            cell.TeamLogo.Image = Common.FromUrl(currentEvent.Team.Icon);
            cell.LocationAddress.Text = location.Address;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            
        }
    }
}