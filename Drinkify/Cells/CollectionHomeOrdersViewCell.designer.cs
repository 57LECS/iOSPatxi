// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Drinkify.Storyboards
{
	[Register ("CollectionHomeOrdersViewCell")]
	partial class CollectionHomeOrdersViewCell
	{
		[Outlet]
		UIKit.UIImageView imgBackGround { get; set; }

		[Outlet]
		UIKit.UILabel labelOrders { get; set; }

		[Action ("btnOrders:")]
		partial void btnOrders (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imgBackGround != null) {
				imgBackGround.Dispose ();
				imgBackGround = null;
			}

			if (labelOrders != null) {
				labelOrders.Dispose ();
				labelOrders = null;
			}
		}
	}
}
