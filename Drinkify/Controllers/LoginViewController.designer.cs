// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Drinkify.Controllers
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UIButton btnConfirmarLogin { get; set; }

		[Outlet]
		UIKit.UIImageView imgLogin { get; set; }

		[Outlet]
		UIKit.UILabel lblContraLogin { get; set; }

		[Outlet]
		UIKit.UILabel lblCorreoLogin { get; set; }

		[Outlet]
		UIKit.UITextField txtContraLogin { get; set; }

		[Outlet]
		UIKit.UITextField txtCorreoLogin { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgLogin != null) {
				imgLogin.Dispose ();
				imgLogin = null;
			}

			if (lblCorreoLogin != null) {
				lblCorreoLogin.Dispose ();
				lblCorreoLogin = null;
			}

			if (txtCorreoLogin != null) {
				txtCorreoLogin.Dispose ();
				txtCorreoLogin = null;
			}

			if (lblContraLogin != null) {
				lblContraLogin.Dispose ();
				lblContraLogin = null;
			}

			if (txtContraLogin != null) {
				txtContraLogin.Dispose ();
				txtContraLogin = null;
			}

			if (btnConfirmarLogin != null) {
				btnConfirmarLogin.Dispose ();
				btnConfirmarLogin = null;
			}
		}
	}
}
