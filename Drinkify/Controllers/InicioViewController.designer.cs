// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Drinkify.Controllers
{
    [Register ("InicioViewController")]
    partial class InicioViewController
    {
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
