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
    [Register ("TableCatalogViewCell")]
    partial class TableCatalogViewCell
    {
        [Outlet]
        UIKit.UIButton btnAgregarProducto { get; set; }


        [Outlet]
        UIKit.UIImageView imgProd { get; set; }


        [Outlet]
        UIKit.UILabel txtCant { get; set; }


        [Outlet]
        UIKit.UILabel txtDesc { get; set; }


        [Outlet]
        UIKit.UILabel txtNombre { get; set; }


        [Outlet]
        UIKit.UITextField txtNumber { get; set; }


        [Outlet]
        UIKit.UILabel txtPrecio { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAgregarProducto != null) {
                btnAgregarProducto.Dispose ();
                btnAgregarProducto = null;
            }

            if (imgProd != null) {
                imgProd.Dispose ();
                imgProd = null;
            }

            if (txtCant != null) {
                txtCant.Dispose ();
                txtCant = null;
            }

            if (txtDesc != null) {
                txtDesc.Dispose ();
                txtDesc = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }

            if (txtNumber != null) {
                txtNumber.Dispose ();
                txtNumber = null;
            }

            if (txtPrecio != null) {
                txtPrecio.Dispose ();
                txtPrecio = null;
            }
        }
    }
}