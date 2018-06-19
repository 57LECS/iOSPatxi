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
    [Register ("CheckOutViewController")]
    partial class CheckOutViewController
    {
        [Outlet]
        UIKit.UIButton btnOrder { get; set; }


        [Outlet]
        UIKit.UICollectionView CheckOutCollectionView { get; set; }


        [Outlet]
        UIKit.UITextField txtCantidad { get; set; }


        [Outlet]
        UIKit.UITextField txtFormPago { get; set; }


        [Outlet]
        UIKit.UITextField txtNombre { get; set; }


        [Outlet]
        UIKit.UITextField txtTotal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnOrder != null) {
                btnOrder.Dispose ();
                btnOrder = null;
            }

            if (CheckOutCollectionView != null) {
                CheckOutCollectionView.Dispose ();
                CheckOutCollectionView = null;
            }

            if (txtCantidad != null) {
                txtCantidad.Dispose ();
                txtCantidad = null;
            }

            if (txtFormPago != null) {
                txtFormPago.Dispose ();
                txtFormPago = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }

            if (txtTotal != null) {
                txtTotal.Dispose ();
                txtTotal = null;
            }
        }
    }
}