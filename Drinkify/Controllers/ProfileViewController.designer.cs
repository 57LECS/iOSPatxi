// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Drinkify.Storyboards
{
    [Register ("ProfileViewController")]
    partial class ProfileViewController
    {
        [Outlet]
        UIKit.UIBarButtonItem btnBack { get; set; }


        [Outlet]
        UIKit.UIButton btnRenew { get; set; }


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
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (btnRenew != null) {
                btnRenew.Dispose ();
                btnRenew = null;
            }

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
        }
    }
}