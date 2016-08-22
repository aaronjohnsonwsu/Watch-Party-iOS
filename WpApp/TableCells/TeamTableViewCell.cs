using Foundation;
using System;
using UIKit;

namespace WpApp
{
    public partial class TeamTableViewCell : UITableViewCell
    {
        public UILabel TeamName => this.TeamNameLabel;
        public UIImageView Logo => this.TeamLogoImageView;

        public TeamTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}