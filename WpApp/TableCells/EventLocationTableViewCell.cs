using System;
using UIKit;

namespace WpApp.TableCells
{
    public partial class EventLocationTableViewCell : UITableViewCell
    {
        public UILabel LocationName => this.LocationNameLabel;
        public UILabel LocationAddress => this.LocationAddressLabel;

        public EventLocationTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}