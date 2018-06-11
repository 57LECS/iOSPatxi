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
    [Register ("CollectionBebidaViewCell")]
    partial class CollectionBebidaViewCell
    {
        [Outlet]
        UIKit.UIButton btnPrincipal { get; set; }


        [Outlet]
        UIKit.UIImageView imgFondo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnPrincipal != null) {
                btnPrincipal.Dispose ();
                btnPrincipal = null;
            }

            if (imgFondo != null) {
                imgFondo.Dispose ();
                imgFondo = null;
            }
        }
    }
}