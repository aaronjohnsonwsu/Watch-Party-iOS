using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using UIKit;
using WpApp.Core.Models;
using WpApp.Core.Services;
using WpApp.TableCells;
using WpApp.ViewControllers;

namespace WpApp
{
    public partial class EventTeamController : UIViewController, IUITableViewDataSource
    {
        private List<Team> _results;
        private List<Team> _allTeams;
        private readonly WatchPartyApi _watchPartyService = new WatchPartyApi();

        public string Search;

        public EventTeamController (IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            _results = await _watchPartyService.GetTeams();

            _allTeams = _results;

            TeamTableView.WeakDataSource = this;

            this.TeamNameSearchBar.TextChanged += TeamNameSearchBar_TextChanged;
        }

        private void TeamNameSearchBar_TextChanged(object sender, UISearchBarTextChangedEventArgs e)
        {
            var searchKeyword = this.TeamNameSearchBar.Text;

            if (!string.IsNullOrWhiteSpace(searchKeyword))
            {
                _results = _allTeams.Where(t => t.Name.Contains(searchKeyword)).ToList();

                this.TeamTableView.ReloadData();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return (nint)_results.Count;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (TeamTableViewCell)tableView.DequeueReusableCell("TeamCell", indexPath);

            var currentTeam = _results[indexPath.Row];

            cell.TeamName.Text = currentTeam.Name;
            cell.Logo.Image = FromUrl(currentTeam.Icon);

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var scheduleViewController = segue.DestinationViewController as EventTeamScheduleController;

            if (scheduleViewController != null)
            {
                scheduleViewController.SelectedTeam = _results[TeamTableView.IndexPathForSelectedRow.Row];
            }
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