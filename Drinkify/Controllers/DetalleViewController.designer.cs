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
    [Register ("DetalleViewController")]
    partial class DetalleViewController
    {
        [Outlet]
        UIKit.UIBarButtonItem btnCheckOut { get; set; }


        [Outlet]
        UIKit.UIBarButtonItem btnRegresar { get; set; }


        [Outlet]
        UIKit.UITableView CatalogTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCheckOut != null) {
                btnCheckOut.Dispose ();
                btnCheckOut = null;
            }

            if (btnRegresar != null) {
                btnRegresar.Dispose ();
                btnRegresar = null;
            }

            if (CatalogTableView != null) {
                CatalogTableView.Dispose ();
                CatalogTableView = null;
            }
        }
    }
}