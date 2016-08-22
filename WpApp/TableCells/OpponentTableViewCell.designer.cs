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
    [Register ("OpponentTableViewCell")]
    partial class OpponentTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView OpponentImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OpponentLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (OpponentImageView != null) {
                OpponentImageView.Dispose ();
                OpponentImageView = null;
            }

            if (OpponentLabel != null) {
                OpponentLabel.Dispose ();
                OpponentLabel = null;
            }
        }
    }
}