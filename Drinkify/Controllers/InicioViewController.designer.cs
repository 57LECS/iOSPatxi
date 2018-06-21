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
    [Register ("InicioViewController")]
    partial class InicioViewController
    {
        [Outlet]
        UIKit.UIButton btnLogin { get; set; }


        [Outlet]
        UIKit.UIButton btnRegistro { get; set; }


        [Outlet]
        UIKit.UIImageView imgAnimacion { get; set; }


        [Outlet]
        UIKit.UIImageView imgLogo { get; set; }


        [Action ("btnIrLogin:")]
        partial void btnIrLogin (Foundation.NSObject sender);


        [Action ("btnIrRegistrar:")]
        partial void btnIrRegistrar (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnLogin != null) {
                btnLogin.Dispose ();
                btnLogin = null;
            }

            if (btnRegistro != null) {
                btnRegistro.Dispose ();
                btnRegistro = null;
            }

            if (imgAnimacion != null) {
                imgAnimacion.Dispose ();
                imgAnimacion = null;
            }

            if (imgLogo != null) {
                imgLogo.Dispose ();
                imgLogo = null;
            }
        }
    }
}