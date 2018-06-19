// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using Drinkify.Helper;
using System.Collections.Generic;
using Patxi.Models;

namespace Drinkify.Storyboards
{
    public partial class CheckOutViewController : UIViewController, IUICollectionViewDataSource, IUICollectionViewDelegate, IUICollectionViewDelegateFlowLayout
    {
        List<Producto> productos;
	
		public CheckOutViewController (IntPtr handle) : base (handle)
		{
            
		}

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            productos = DataPersistanceClass.products;

            CheckOutCollectionView.Delegate = this;
            CheckOutCollectionView.DataSource = this;
		}

		public override void ViewWillAppear(bool animated)
		{
            base.ViewWillAppear(animated);
            CheckOutCollectionView.ReloadData();
            setDatos();

		}


        void setDatos(){
            txtNombre.Text = DataPersistanceClass.persona.Name??"Luis Edgardo Calderon";
            txtCantidad.Text = productos.Count.ToString();
            txtFormPago.Text = "Tarjeta con terminal";
            txtFormPago.Enabled = false;
            txtTotal.Enabled = false;
            txtNombre.Enabled = false;
            txtCantidad.Enabled = false;
        }

		public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            Producto producto = productos[int.Parse(indexPath.Item.ToString())];
            var cell = CheckOutCollectionView.DequeueReusableCell(CollectionCheckOutCell.Key, indexPath) as CollectionCheckOutCell;
            cell.txtCantidad = producto.ItemsBought;
            cell.lblNombre = producto.Name;
            int number = int.Parse(cell.txtCantidad) * int.Parse(producto.Price.ToString());
            cell.lblTotalPrice = $"${number.ToString()}";
            return cell;
        }

        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return productos.Count;
        }

        [Export("numberOfSectionsInCollectionView:")]
        public nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }
	}
}
