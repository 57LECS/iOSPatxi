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
	[Register ("CollectionBotanaViewCell")]
	partial class CollectionBotanaViewCell
	{
		[Outlet]
		UIKit.UIButton btnBotanas { get; set; }

		[Outlet]
		UIKit.UIImageView imgBackGround { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnBotanas != null) {
				btnBotanas.Dispose ();
				btnBotanas = null;
			}

			if (imgBackGround != null) {
				imgBackGround.Dispose ();
				imgBackGround = null;
			}
		}
	}
}
