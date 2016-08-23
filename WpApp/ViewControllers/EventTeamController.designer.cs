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
    [Register ("EventTeamController")]
    partial class EventTeamController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar TeamNameSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TeamTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TeamNameSearchBar != null) {
                TeamNameSearchBar.Dispose ();
                TeamNameSearchBar = null;
            }

            if (TeamTableView != null) {
                TeamTableView.Dispose ();
                TeamTableView = null;
            }
        }
    }
}