using System;
using System.Collections.Generic;
using Drinkify.Helper;
using Drinkify.Storyboards;
using Firebase.Database;
using Foundation;
using Patxi.Models;
using UIKit;

namespace Drinkify.Controllers
{
    public partial class LoginViewController : UIViewController
    {
        System.Collections.Generic.List<Persona> personas;
        Persona personita;
        public LoginViewController(IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            btnConfirmarLogin.TouchUpInside += delegate
            {
                
            };
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {

            if (segue.Identifier.Equals("segueMenusito") == true)
            {
                DataPersistanceClass.persona = personita;
            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtContraLogin.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtCorreoLogin.Text))
                return false;
            else
                return true;

        }

        public void SetUserData()
        {
            personas = new List<Persona>();
            DatabaseReference rootNode = Database.DefaultInstance.GetRootReference();
            //nuint quantity;
            DatabaseReference bebidas = rootNode.GetChild("0").GetChild("Usuarios");
            bebidas.ObserveSingleEvent(DataEventType.Value, (snapshot) => {
                if (!snapshot.Exists)
                    return;

                var personaDiccionary = snapshot.GetValue<NSDictionary>();
                Persona personitaa;
                for (int i = 0; i < personaDiccionary.Keys.Length; i++)
                {
                    var nskey = personaDiccionary.Keys[i] as NSString;
                    var key = personaDiccionary.ValueForKey(nskey);
                    personitaa = new Persona();
                    personitaa.Id = nskey.ToString();
                    personitaa.Name = key.ValueForKey((NSString)"Nombre").ToString();
                    personitaa.Email = key.ValueForKey((NSString)"Correo").ToString();
                    personitaa.Password = key.ValueForKey((NSString)"Password").ToString();
                    personas.Add(personitaa);
                }

                foreach (var item in personas)
                {
                    if (item.Email == txtCorreoLogin.Text)
                    {
                        if (txtContraLogin.Text == item.Password)
                        {
                            personita = item;
                        }
                        else
                        {
                            UIAlertController alertController = UIAlertController.Create("Password", $"Contraseña incorrecta", UIAlertControllerStyle.Alert);
                            alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                            PresentViewController(alertController, true, null);
                            break;

                        }
                    }
                }
                UIAlertController alertControllerr = UIAlertController.Create("Password", $"Correo no encotrado", UIAlertControllerStyle.Alert);
                alertControllerr.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                PresentViewController(alertControllerr, true, null);



            }, (error) => {
                Console.WriteLine(error.LocalizedDescription);
            });



        }

		public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
		{
            if (CamposValidos())
            {
                SetUserData();
            }

            if (personita != null)
                return base.ShouldPerformSegue("segueMenusito", btnConfirmarLogin);
            else
                return false;
		}



	}
}

