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

            if (lblTotal != null) {
                lblTotal.Dispose ();
                lblTotal = null;
            }

            if (txtCant != null) {
                txtCant.Dispose ();
                txtCant = null;
            }
        }
    }
}