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
    [Register ("SearchEventsTeamController")]
    partial class SearchEventsTeamController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TeamsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TeamsTableView != null) {
                TeamsTableView.Dispose ();
                TeamsTableView = null;
            }
        }
    }
}