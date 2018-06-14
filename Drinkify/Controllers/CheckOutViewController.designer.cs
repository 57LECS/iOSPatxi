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
			if (txtNombre != null) {
				txtNombre.Dispose ();
				txtNombre = null;
			}

			if (txtFormPago != null) {
				txtFormPago.Dispose ();
				txtFormPago = null;
			}

			if (txtCantidad != null) {
				txtCantidad.Dispose ();
				txtCantidad = null;
			}

			if (txtTotal != null) {
				txtTotal.Dispose ();
				txtTotal = null;
			}

			if (CheckOutCollectionView != null) {
				CheckOutCollectionView.Dispose ();
				CheckOutCollectionView = null;
			}

			if (btnOrder != null) {
				btnOrder.Dispose ();
				btnOrder = null;
			}
		}
	}
}
