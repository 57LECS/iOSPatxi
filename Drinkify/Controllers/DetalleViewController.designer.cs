// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
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
