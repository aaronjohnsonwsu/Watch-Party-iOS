using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using WpApp.Core.Models;
using WpApp.Helpers;
using WpApp.TableCells;

namespace WpApp.ViewControllers
{
    public partial class EventTeamScheduleController : UIViewController, IUITableViewDataSource
    {
        public Team SelectedTeam;

        public EventTeamScheduleController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.ScheduleTableView.WeakDataSource = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return (nint)SelectedTeam.Games.Count;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (OpponentTableViewCell)tableView.DequeueReusableCell("OpponentCell", indexPath);

            var currentOpponent = SelectedTeam.Games[indexPath.Row];

            cell.OpponentName.Text = currentOpponent.Opponent + " " + currentOpponent.GameDate;
            cell.OpponentLogo.Image = Common.FromUrl(currentOpponent.OpponentLogo);

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            //base.PrepareForSegue(segue, sender);

            var eventLocationController = segue.DestinationViewController as EventLocationController;

            if (eventLocationController != null)
            {
                eventLocationController.SelectedTeam = SelectedTeam;
                eventLocationController.SelectedGame = SelectedTeam.Games[ScheduleTableView.IndexPathForSelectedRow.Row];
            }
        }

    }
}