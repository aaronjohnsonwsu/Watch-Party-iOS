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
    [Register ("EventTeamScheduleController")]
    partial class EventTeamScheduleController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem EventTeamScheduleNavigation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ScheduleTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TeamsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EventTeamScheduleNavigation != null) {
                EventTeamScheduleNavigation.Dispose ();
                EventTeamScheduleNavigation = null;
            }

            if (ScheduleTableView != null) {
                ScheduleTableView.Dispose ();
                ScheduleTableView = null;
            }

            if (TeamsTableView != null) {
                TeamsTableView.Dispose ();
                TeamsTableView = null;
            }
        }
    }
}