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
	[Register ("CollectionCheckOutCell")]
	partial class CollectionCheckOutCell
	{
		[Outlet]
		UIKit.UILabel lblTitle { get; set; }

		[Outlet]
		UIKit.UILabel lblTotal { get; set; }

		[Outlet]
		UIKit.UITextField txtCant { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTitle != null) {
				lblTitle.Dispose ();
				lblTitle = null;
			}

			if (txtCant != null) {
				txtCant.Dispose ();
				txtCant = null;
			}

			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}
		}
	}
}
