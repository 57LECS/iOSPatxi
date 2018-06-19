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
    [Register ("CollectionHomeOrdersViewCell")]
    partial class CollectionHomeOrdersViewCell
    {
        [Outlet]
        UIKit.UIImageView imgBackGround { get; set; }


        [Outlet]
        UIKit.UILabel labelOrders { get; set; }


        [Action ("btnOrders:")]
        partial void btnOrders (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (imgBackGround != null) {
                imgBackGround.Dispose ();
                imgBackGround = null;
            }

            if (labelOrders != null) {
                labelOrders.Dispose ();
                labelOrders = null;
            }
        }
    }
}