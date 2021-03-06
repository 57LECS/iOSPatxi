// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using CoreGraphics;
using UIKit;
using Patxi.Models;
using Drinkify.Helper;


namespace Drinkify.Storyboards
{
    public partial class TableCatalogViewCell : UITableViewCell
	{
        UIToolbar toolbar;
        public static readonly NSString Key = new NSString(nameof(TableCatalogViewCell));
        public Producto producto;
        public Pedido pedido;
        public UIViewController viewController;
        public Action btnFunc;
        public bool hideInputs = false;

        public TableCatalogViewCell(IntPtr handle) : base(handle)
        {

        }

        public UIImage ProductImage
        {
            get => imgProd.Image;
            set => imgProd.Image = value;
        }

        public UIImageView ImgnProduct
        {
            get => imgProd;
            set => imgProd = value;
            
        } 

        public string NameText
        {
            get => txtNombre.Text;
            set => txtNombre.Text = value;
        }

        public string QuantityText
        {
            get => txtCant.Text;
            set => txtCant.Text = value;
        }

        public string DescriptionText
        {
            get => txtDesc.Text;
            set => txtDesc.Text = value;
        }

        public string PriceText
        {
            get => txtPrecio.Text;
            set => txtPrecio.Text = value;
        }

        public string boughtNumber
        {
            get => txtNumber.Text;
            set => txtNumber.Text = value;
        }



        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            txtNumber.Hidden = hideInputs;
            //btnAgregarProducto.Hidden = hideInputs;
            if (!hideInputs)
                addToolbar();
            else
                btnAgregarProducto.SetTitle("Detalles", UIControlState.Normal); 
            
                
            btnAgregarProducto.TouchUpInside += delegate (object sender, EventArgs e)
            {


                if(hideInputs){
                    var vc = viewController as DetalleViewController;
                    vc.selectedOrder = pedido;
                    viewController.PerformSegue("segueToDetails", this);
                }
                UIAlertController alertController;
                if (string.IsNullOrEmpty(boughtNumber)){
                    
                    alertController = UIAlertController.Create("Cantidad", $"Debes de ingresar una cantidad", UIAlertControllerStyle.Alert);
                    alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                }
                else{
                    int xx;
                    bool bandera = false;
                    if(int.TryParse(boughtNumber,out xx)){
                        alertController = UIAlertController.Create("Agregar al carrito", $"Vas a agregrar {boughtNumber} de {NameText} al carrito", UIAlertControllerStyle.Alert);
                        alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, (UIAlertAction obj) => {
                            
                            var pd = DataPersistanceClass.products.IndexOf(producto);
                            if(pd>=0){
                                var prodint = int.Parse(DataPersistanceClass.products[pd].ItemsBought);
                                prodint += xx;
                                DataPersistanceClass.products[pd].ItemsBought = prodint.ToString();
                            }
                            else{
                                foreach (Producto item in DataPersistanceClass.products)
                                {
                                    if(item.Id == producto.Id){
                                        var prodint = int.Parse(item.ItemsBought);
                                        prodint += xx;
                                        item.ItemsBought = prodint.ToString();
                                        bandera = true;
                                    }
                                }
                                if(!bandera){
                                    producto.ItemsBought = xx.ToString();
                                    DataPersistanceClass.products.Add(producto);
                                }

                            }


                        }));
                        alertController.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null));
                    }
                    else{
                        alertController = UIAlertController.Create("Error", "Verifica la cantidad ingresada", UIAlertControllerStyle.Alert);
                        alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                    }
                    boughtNumber = "";

                }
                    



                viewController.PresentViewController(alertController, true, null);
                //UIApplication.SharedApplication.KeyWindow?.RootViewController.PresentViewController(alertController, true, null);
            };



        }



        void addToolbar(){
            toolbar = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), viewController.View.Frame.Size.Width, new nfloat(44.0f)));
            toolbar.TintColor = UIColor.White;
            toolbar.BarStyle = UIBarStyle.Black;
            toolbar.Translucent = false;

            toolbar.Items = new UIBarButtonItem[]{
                new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
                    this.txtNumber.ResignFirstResponder();
                })
            };

            txtNumber.KeyboardType = UIKeyboardType.NumberPad;
            txtNumber.InputAccessoryView = toolbar;

        }
        //public void agregarMetodobtn(Action func) => btnAgregarProducto.TouchUpInside += func;

  //      partial void btnAgregar(NSObject sender)
		//{
            //UIAlertController.Create("Agregado", "Se agrego el obejto", UIAlertControllerStyle.Alert);
            //TODO: MOstrar alerta;

            //var alertController = UIAlertController.Create("Agregar al carrito", $"Vas a agregrar {producto.ItemsBought}", UIAlertControllerStyle.Alert);
            //alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default,(UIAlertAction obj) => {
            //    producto.ItemsBought = boughtNumber;
            //    DataPersistanceClass.products.Add(producto);

            //}));
            //alertController.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null));

            //UIApplication.SharedApplication.KeyWindow?.RootViewController.PresentViewController(alertController, true, null);
		//}
        

        public NSIndexPath IndexPath
        {
            get;
            set;
        }




	}


}