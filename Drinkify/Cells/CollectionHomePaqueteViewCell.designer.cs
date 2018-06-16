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
	[Register ("CollectionHomePaqueteViewCell")]
	partial class CollectionHomePaqueteViewCell
	{
		[Outlet]
		UIKit.UIButton btnPackage { get; set; }

		[Outlet]
		UIKit.UIImageView imgBackground { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgBackground != null) {
				imgBackground.Dispose ();
				imgBackground = null;
			}

			if (btnPackage != null) {
				btnPackage.Dispose ();
				btnPackage = null;
			}
		}
	}
}
