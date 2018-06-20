// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using Firebase.Storage;
using Foundation;
using Patxi.Models;
using UIKit;
namespace Drinkify.Storyboards
{
    public partial class DetalleViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate
	{

        List<Producto> Productos = new List<Producto>();
        public bool isOrders = false;
        public bool isBebidas = false;
        public bool isBotanas= false;
        public NSDictionary diccionary;
        public Pedido selectedOrder;
        NSString name = (NSString)"Nombre";
        NSString price = (NSString)"Precio";
        NSString qty = (NSString)"Quantity";
        NSString desc = (NSString)"Descripcion";
        List<Producto> productos;
        List<UIImage> images;
        StorageReference rootRefStorage;

        //int contador = 0;

		public DetalleViewController (IntPtr handle) : base (handle)
		{
            
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CatalogTableView.DataSource = this;
            CatalogTableView.Delegate = this;

            btnRegresar.Clicked += delegate {
                DismissViewController(true, null);
            };

            btnCheckOut.Clicked += delegate {
                //TODO: enviar a pantalla de checkOut

            };
            images = new List<UIImage>();
            rootRefStorage = Storage.DefaultInstance.GetRootReference();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier.Equals("segueToDetails") == true)
            {
                var vc = segue.DestinationViewController as PatxiTrackerViewController;
                vc.pedido = selectedOrder;
            }
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            productos = new List<Producto>();
            if(isOrders){
                var cell = tableView.DequeueReusableCell("TableCell", indexPath) as TableCatalogViewCell;
                var keyString = diccionary.Keys[indexPath.Row] as NSString;
                var key = diccionary.ValueForKey(keyString);

                cell.NameText = key.ValueForKey((NSString)"Fecha").ToString();
                cell.PriceText = $"${key.ValueForKey((NSString)"TotalPrecio").ToString()}";
                cell.QuantityText = $"{key.ValueForKey((NSString)"TotalProductos").ToString()} producto(s)";
                cell.DescriptionText = key.ValueForKey((NSString)"Descripcion").ToString();
                cell.hideInputs = true;
                Pedido pedido = new Pedido();
                pedido.Id =keyString.ToString();
                pedido.Date = key.ValueForKey((NSString)"Fecha").ToString();
                pedido.TotalPrice = double.Parse(key.ValueForKey((NSString)"TotalPrecio").ToString());
                pedido.TotalProducts = double.Parse(key.ValueForKey((NSString)"TotalProductos").ToString());
                pedido.Descripcion = key.ValueForKey((NSString)"Descripcion").ToString();
                pedido.Address = key.ValueForKey((NSString)"Direccion").ToString();
                pedido.Repartidor = key.ValueForKey((NSString)"Repartidor").ToString();
                pedido.IdStatus = int.Parse(key.ValueForKey((NSString)"Status").ToString());
                cell.pedido = pedido;
                cell.viewController = this;
                cell.ProductImage = UIImage.FromBundle("Tequila1");

                return cell;
            }
            else if (isBebidas || isBotanas)
            {
                var cell = tableView.DequeueReusableCell("TableCell", indexPath) as TableCatalogViewCell;
                var keyString = diccionary.Keys[indexPath.Row] as NSString;
                var key = diccionary.ValueForKey(keyString);
                cell.hideInputs = false;

                Producto prod = new Producto();
                prod.Id = keyString.ToString();
                prod.Name = key.ValueForKey(name).ToString();
                prod.Price = double.Parse(key.ValueForKey(price).ToString());
                prod.Quantity = key.ValueForKey(qty).ToString();
                prod.Description = key.ValueForKey(desc).ToString();


                cell.NameText = prod.Name;
                cell.PriceText = $"${prod.Price.ToString()}";
                cell.QuantityText = prod.Quantity;
                cell.DescriptionText = prod.Description;
                getImagene(prod.Id,cell.ImgnProduct);
                cell.viewController = this;
                //cell.prodKey = keyString;

                cell.producto = prod;
                productos.Add(prod);
                return cell;
            }


            return new UITableViewCell();

        }



        [Export("numberOfSectionsInTableView:")]
        public nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            try
            {
                return diccionary.Keys.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            //return Productos.Count;
        }

        UIImage getImageFromData(UIImage img){
            var xx = DateTime.Now;
            UIImage asd = img;

            //CatalogTableView.ReloadData();
            images.Add(asd);
            return asd;
        }



        void getImagene(string id, UIImageView view)
        {
            StorageReference profileImageRef = rootRefStorage.GetChild($"products/{id}.jpg");
            StorageReference genericImageRef = rootRefStorage.GetChild($"products/generic.jpg");
            UIImage img = new UIImage();
            var ss = profileImageRef.GetData(1 * 1024 * 1024, (data, error) => {
                try
                {
                    if(data!=null)
                        view.Image = UIImage.LoadFromData(data);
                    else{
                        genericImageRef.GetData(1 * 1024 * 1024, (dataa, errorr) => {

                            view.Image = UIImage.LoadFromData(dataa);
                        });
                    }
                        
                }
                catch (Exception ex)
                {
                    //no tiene imagen
                    Console.WriteLine("Mensaje:" + ex.Message);

                }

            });

        }


	}
}
