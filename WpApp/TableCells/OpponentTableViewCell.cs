using System;
using UIKit;

namespace WpApp.TableCells
{
    public partial class OpponentTableViewCell : UITableViewCell
    {
        public UILabel OpponentName => this.OpponentLabel;
        public UIImageView OpponentLogo => this.OpponentImageView;

        public OpponentTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}