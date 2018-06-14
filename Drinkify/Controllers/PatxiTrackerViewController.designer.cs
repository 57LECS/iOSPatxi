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
	[Register ("PatxiTrackerViewController")]
	partial class PatxiTrackerViewController
	{
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
		
		void ReleaseDesignerOutlets ()
		{
			if (imgStatus != null) {
				imgStatus.Dispose ();
				imgStatus = null;
			}

			if (lblStatus != null) {
				lblStatus.Dispose ();
				lblStatus = null;
			}

			if (lblRepartidor != null) {
				lblRepartidor.Dispose ();
				lblRepartidor = null;
			}

			if (lblDireccion != null) {
				lblDireccion.Dispose ();
				lblDireccion = null;
			}

			if (lblCantidad != null) {
				lblCantidad.Dispose ();
				lblCantidad = null;
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
