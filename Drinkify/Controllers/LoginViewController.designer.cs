// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Drinkify.Controllers
{
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        UIKit.UIButton btnConfirmarLogin { get; set; }


        [Outlet]
        UIKit.UIImageView imgLogin { get; set; }


        [Outlet]
        UIKit.UILabel lblContraLogin { get; set; }


        [Outlet]
        UIKit.UILabel lblCorreoLogin { get; set; }


        [Outlet]
        UIKit.UITextField txtContraLogin { get; set; }


        [Outlet]
        UIKit.UITextField txtCorreoLogin { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnConfirmarLogin != null) {
                btnConfirmarLogin.Dispose ();
                btnConfirmarLogin = null;
            }

            if (imgLogin != null) {
                imgLogin.Dispose ();
                imgLogin = null;
            }

            if (lblContraLogin != null) {
                lblContraLogin.Dispose ();
                lblContraLogin = null;
            }

            if (lblCorreoLogin != null) {
                lblCorreoLogin.Dispose ();
                lblCorreoLogin = null;
            }

            if (txtContraLogin != null) {
                txtContraLogin.Dispose ();
                txtContraLogin = null;
            }

            if (txtCorreoLogin != null) {
                txtCorreoLogin.Dispose ();
                txtCorreoLogin = null;
            }
        }
    }
}