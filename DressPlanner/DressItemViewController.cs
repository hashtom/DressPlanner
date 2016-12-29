using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace DressPlanner
{
    public partial class DressItemViewController : UITableViewController
    {
		List<DressItem> dressitem;

        public DressItemViewController (IntPtr handle) : base (handle)
        {
			dressitem = new List<DressItem> {
				new DressItem {ItemName="シャツ1",DressPhotoFile="Shirt_sample.jpg",Category = ItemCategory.Shirt},
				new DressItem {ItemName="パンツ1",DressPhotoFile="Pants_sample.jpg",Category = ItemCategory.Pants},
				new DressItem {ItemName="智明",DressPhotoFile="Tomo_sample.jpg",Category = ItemCategory.Other},
				new DressItem {ItemName="シャツ2",DressPhotoFile="Shirt_sample.jpg",Category = ItemCategory.Shirt},
				new DressItem {ItemName="パンツ2",DressPhotoFile="Pants_sample.jpg",Category = ItemCategory.Pants},
				new DressItem {ItemName="パンツ3",DressPhotoFile="Pants_sample.jpg",Category = ItemCategory.Pants},
				new DressItem {ItemName="シャツ3",DressPhotoFile="Shirt_sample.jpg",Category = ItemCategory.Shirt},
				new DressItem {ItemName="智明",DressPhotoFile="Tomo_sample.jpg",Category = ItemCategory.Other}
			};
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			TableView.Source = new DressItemTableSource(dressitem.ToArray());
		
		}
    }
}