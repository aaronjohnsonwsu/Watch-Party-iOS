using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using WpApp.Core.Models;
using WpApp.Core.Services;
using WpApp.TableCells;

namespace WpApp.ViewControllers
{
    public partial class EventLocationController : UIViewController, IUITableViewDataSource
    {
        private List<GoogleAutoCompleteResult> _results;
        private readonly GooglePlaceSearchService _googlePlaceService = new GooglePlaceSearchService();
        public Team SelectedTeam;
        public Game SelectedGame;

        public EventLocationController(IntPtr handle) : base(handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            _results = await _googlePlaceService.AutoComplete("lapel");
            LocationsTableView.WeakDataSource = this;

            this.LocationNameSearchBar.TextChanged += LocationNameSearchBar_TextChanged;
        }

        private async void LocationNameSearchBar_TextChanged(object sender, UISearchBarTextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.LocationNameSearchBar.Text))
            {
                _results = await _googlePlaceService.AutoComplete(this.LocationNameSearchBar.Text);
                this.LocationsTableView.ReloadData();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return (nint) _results.Count;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (EventLocationTableViewCell) tableView.DequeueReusableCell("EventLocationCell", indexPath);

            var currentLocation = _results[indexPath.Row];

            cell.LocationName.Text = currentLocation.Name;
            cell.LocationAddress.Text = currentLocation.Address;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var detailViewController = segue.DestinationViewController as EventCreateController;

            if (detailViewController != null)
            {
                detailViewController.PlaceId = _results[LocationsTableView.IndexPathForSelectedRow.Row].PlaceId;
                detailViewController.SelectedGame = SelectedGame;
                detailViewController.SelectedTeam = SelectedTeam;
            }
        }
    }
}