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
	[Register ("CollectionHomeViewCell")]
	partial class CollectionHomeViewCell
	{
		[Outlet]
		UIKit.UIButton btnProfile { get; set; }

		[Outlet]
		UIKit.UIImageView imgBackground { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnProfile != null) {
				btnProfile.Dispose ();
				btnProfile = null;
			}

			if (imgBackground != null) {
				imgBackground.Dispose ();
				imgBackground = null;
			}
		}
	}
}
