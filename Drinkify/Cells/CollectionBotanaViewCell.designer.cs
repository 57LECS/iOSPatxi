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