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
    [Register ("CollectionHomeViewCell")]
    partial class CollectionHomeViewCell
    {
        [Outlet]
        UIKit.UIButton btnProfile { get; set; }


        [Outlet]
        UIKit.UIImageView imgBackground { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnProfile != null) {
                btnProfile.Dispose ();
                btnProfile = null;
            }

            if (imgBackground != null) {
                imgBackground.Dispose ();
                imgBackground = null;
            }
        }
    }
}