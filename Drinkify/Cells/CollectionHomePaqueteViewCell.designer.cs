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
    [Register ("CollectionHomePaqueteViewCell")]
    partial class CollectionHomePaqueteViewCell
    {
        [Outlet]
        UIKit.UIButton btnPackage { get; set; }


        [Outlet]
        UIKit.UIImageView imgBackground { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnPackage != null) {
                btnPackage.Dispose ();
                btnPackage = null;
            }

            if (imgBackground != null) {
                imgBackground.Dispose ();
                imgBackground = null;
            }
        }
    }
}