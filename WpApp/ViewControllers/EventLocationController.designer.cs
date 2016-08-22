// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;

namespace WpApp.ViewControllers
{
    [Register ("EventLocationController")]
    partial class EventLocationController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar LocationNameSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView LocationsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LocationNameSearchBar != null) {
                LocationNameSearchBar.Dispose ();
                LocationNameSearchBar = null;
            }

            if (LocationsTableView != null) {
                LocationsTableView.Dispose ();
                LocationsTableView = null;
            }
        }
    }
}