// This file has been autogenerated from a class added in the UI designer.

using System;
using Drinkify.Helper;
using Foundation;
using Patxi.Models;
using UIKit;

namespace Drinkify.Storyboards
{
	public partial class CollectionCheckOutCell : UICollectionViewCell
	{
        public static readonly NSString Key = new NSString(nameof(CollectionCheckOutCell));
        UIToolbar toolbar;
        public UIViewController viewController;
        public UICollectionView collectionView;

        public string txtCantidad
        {
            get => txtCant.Text;
            set => txtCant.Text = value;

        }

        public string lblNombre
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;

        }

        public string lblTotalPrice
        {
            get => lblTotal.Text;
            set => lblTotal.Text = value;

        }

        public UIImageView imgnView
        {
            get => imgView;
            set => imgView = value;

        }

		public override void LayoutSubviews()
		{
            base.LayoutSubviews();
            addToolbar();

            txtCant.EditingDidEnd+= delegate {
                foreach (Producto item in DataPersistanceClass.products)
                {
                    if(item.Name==lblNombre){
                        item.ItemsBought = txtCant.Text;
                    }
                }
            };

		}

        void addToolbar()
        {
            toolbar = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), viewController.View.Frame.Size.Width, new nfloat(44.0f)));
            toolbar.TintColor = UIColor.White;
            toolbar.BarStyle = UIBarStyle.Black;
            toolbar.Translucent = false;
            Producto itm=new Producto();

            toolbar.Items = new UIBarButtonItem[]{
                new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
                    this.txtCant.ResignFirstResponder();

                    int num = 0;
                    foreach (Producto item in DataPersistanceClass.products) {
                        if(item.Name==lblNombre){
                            item.ItemsBought = txtCant.Text;

                            if(item.ItemsBought=="0"||string.IsNullOrWhiteSpace(itm.ItemsBought)){
                                itm =item;
                            }
                        }
                    }
                    if(itm.ItemsBought=="0"||string.IsNullOrWhiteSpace(itm.ItemsBought)){
                        var dsqw = DataPersistanceClass.products.Remove(itm);
                    }
                    else if(!int.TryParse(itm.ItemsBought,out num)){
                        var dsqw = DataPersistanceClass.products.Remove(itm);
                    }
                        
                    var vc = viewController as CheckOutViewController;
                    vc.setDatos();
                    collectionView.ReloadData();


                })
            };

            txtCant.KeyboardType = UIKeyboardType.NumberPad;
            txtCant.InputAccessoryView = toolbar;

        }

		public CollectionCheckOutCell (IntPtr handle) : base (handle)
		{
		}
	}
}
