using System;
using Firebase.Database;
using Foundation;
using UIKit;

namespace Drinkify.Controllers
{
    public partial class RegistroViewController : UIViewController
    {
        public RegistroViewController(IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            try
            {
                //var btn = btnRegistrarAhora;
                btnRegistrarAhora.TouchUpInside += delegate {
                    if (CamposValidos())
                    {
                        InsertarEnFireBase();
                        DismissViewController(true,null);
                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        bool CamposValidos(){
            if (string.IsNullOrWhiteSpace(txtEdadRegistro.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtSexoRegistro.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtContraRegistro.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtCorreoRegistro.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtNombreRegistro.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtContra2Registro.Text))
                return false;
            if (!txtContraRegistro.Text.Equals(txtContra2Registro.Text))
                return false;
            else
                return true;
                
        }

        void InsertarEnFireBase(){
            object[] alcoholKeys = { "Nombre", "Edad", "Correo", "Password", "Sexo", "rutaImagen" };
            object[] alcoholValues = { txtNombreRegistro.Text, txtEdadRegistro.Text, txtCorreoRegistro.Text, txtContraRegistro.Text, txtSexoRegistro.Text, "holis" };
            var qs2 = NSDictionary.FromObjectsAndKeys(alcoholValues, alcoholKeys, alcoholKeys.Length);
            DatabaseReference rootNode = Database.DefaultInstance.GetRootReference();
            DatabaseReference productosNode = rootNode.GetChild("0").GetChild("Usuarios");
            DatabaseReference productoNode = productosNode.GetChildByAutoId();
            productoNode.SetValue<NSDictionary>(qs2);
        }

    }
}

