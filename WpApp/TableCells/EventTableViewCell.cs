using System;
using UIKit;

namespace WpApp.TableCells
{
    public partial class EventTableViewCell : UITableViewCell
    {

        public UILabel EventName => this.GameTitleLabel;
        public UILabel EventLocationName => this.LocationNameLabel;
        public UILabel EventLocationAddress => this.LocationAddressLabel;
        public UIImageView EventTeamLogo => this.TeamImageView;

        public EventTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}