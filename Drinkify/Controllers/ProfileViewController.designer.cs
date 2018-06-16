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
	[Register ("ProfileViewController")]
	partial class ProfileViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem btnBack { get; set; }

		[Outlet]
		UIKit.UIImageView imProfile { get; set; }

		[Outlet]
		UIKit.UITextField txtName { get; set; }

		[Outlet]
		UIKit.UILabel txtTimeRemaining { get; set; }

		[Outlet]
		UIKit.UITextField txtUser { get; set; }

		[Action ("btnToolbarBack:")]
		partial void btnToolbarBack (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imProfile != null) {
				imProfile.Dispose ();
				imProfile = null;
			}

			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}

			if (txtTimeRemaining != null) {
				txtTimeRemaining.Dispose ();
				txtTimeRemaining = null;
			}

			if (txtUser != null) {
				txtUser.Dispose ();
				txtUser = null;
			}

			if (btnBack != null) {
				btnBack.Dispose ();
				btnBack = null;
			}
		}
	}
}
