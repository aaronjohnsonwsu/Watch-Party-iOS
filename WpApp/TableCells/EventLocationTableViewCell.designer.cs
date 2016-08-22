// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;

namespace WpApp.TableCells
{
    [Register ("EventLocationTableViewCell")]
    partial class EventLocationTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LocationAddressLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LocationNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LocationAddressLabel != null) {
                LocationAddressLabel.Dispose ();
                LocationAddressLabel = null;
            }

            if (LocationNameLabel != null) {
                LocationNameLabel.Dispose ();
                LocationNameLabel = null;
            }
        }
    }
}