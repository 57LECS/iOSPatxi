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
	[Register ("TableCatalogViewCell")]
	partial class TableCatalogViewCell
	{
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

		[Action ("btnAgregar:")]
		partial void btnAgregar (Foundation.NSObject sender);

		
		void ReleaseDesignerOutlets ()
		{
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

			if (txtPrecio != null) {
				txtPrecio.Dispose ();
				txtPrecio = null;
			}

			if (txtNumber != null) {
				txtNumber.Dispose ();
				txtNumber = null;
			}
		}
	}
}
