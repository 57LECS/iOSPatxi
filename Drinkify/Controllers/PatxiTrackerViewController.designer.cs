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
    [Register ("PatxiTrackerViewController")]
    partial class PatxiTrackerViewController
    {
        [Outlet]
        UIKit.UIBarButtonItem btnRegresar { get; set; }


        [Outlet]
        UIKit.UIImageView imgStatus { get; set; }


        [Outlet]
        UIKit.UILabel lblCantidad { get; set; }


        [Outlet]
        UIKit.UITextView lblDireccion { get; set; }


        [Outlet]
        UIKit.UILabel lblRepartidor { get; set; }


        [Outlet]
        UIKit.UILabel lblStatus { get; set; }


        [Outlet]
        UIKit.UILabel lblTiempo { get; set; }


        [Outlet]
        UIKit.UILabel lblTotal { get; set; }

        [Action ("btnReturn:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnReturn (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnRegresar != null) {
                btnRegresar.Dispose ();
                btnRegresar = null;
            }

            if (imgStatus != null) {
                imgStatus.Dispose ();
                imgStatus = null;
            }

            if (lblCantidad != null) {
                lblCantidad.Dispose ();
                lblCantidad = null;
            }

            if (lblDireccion != null) {
                lblDireccion.Dispose ();
                lblDireccion = null;
            }

            if (lblRepartidor != null) {
                lblRepartidor.Dispose ();
                lblRepartidor = null;
            }

            if (lblStatus != null) {
                lblStatus.Dispose ();
                lblStatus = null;
            }

            if (lblTiempo != null) {
                lblTiempo.Dispose ();
                lblTiempo = null;
            }

            if (lblTotal != null) {
                lblTotal.Dispose ();
                lblTotal = null;
            }
        }
    }
}