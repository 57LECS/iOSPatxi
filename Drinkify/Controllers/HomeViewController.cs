// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using Patxi.Models;
using UIKit;
using Firebase.Core;
using Firebase.Database;

namespace Drinkify.Storyboards
{
    public partial class HomeViewController : UIViewController, IUICollectionViewDataSource, IUICollectionViewDelegate, IUICollectionViewDelegateFlowLayout
	{
        UIEdgeInsets sectionInsets;
        int itemsPerRow = 2;
		public HomeViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            sectionInsets = new UIEdgeInsets(20, 20, 20, 20);
            collectionView.Delegate = this;
            collectionView.DataSource = this;
            DatabaseReference rootNode = Database.DefaultInstance.GetRootReference();
            nuint quantity;
            DatabaseReference order = rootNode.GetChild("1");
            order.ObserveSingleEvent(DataEventType.Value, (snapshot) => {
                //quantity = snapshot.GetValue<NSNumber>().NUIntValue;

                if (!snapshot.Exists)
                    return;
                
                var data = snapshot.GetValue<NSDictionary>();
                var totalPrice = data.ValueForKey((NSString)"TotalPrice")?.ToString();

            }, (error) => {
                Console.WriteLine(error.LocalizedDescription);
            });
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {

            if (segue.Identifier.Equals("profileSegue") == true)
            {

                var vc = segue.DestinationViewController as ProfileViewController;
                //TODO: Pasar la informacion del usuario para la siguiente pestana
            }
            else if (segue.Identifier.Equals("detalleOrdersSegue") == true)
            {
                var vc = segue.DestinationViewController as DetalleViewController;
                vc.isOrders = true;
                vc.isBebidas = false;
                vc.isBotanas = false;
            }

        }

        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 5;
        }

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {


            var length = collectionView.VisibleCells.Length;
            var title = (Alcoholes)(int)indexPath.Item;


            switch (indexPath.Item)
            {
                case 0:
                    var cellProfile = collectionView.DequeueReusableCell(CollectionHomeViewCell.Key, indexPath) as CollectionHomeViewCell;
                    cellProfile.btnTitle = "Perfil";

                    return cellProfile;

                case 1:
                    var cellOrders = collectionView.DequeueReusableCell(CollectionHomeOrdersViewCell.Key, indexPath) as CollectionHomeOrdersViewCell;

                    cellOrders.lblOrders = "12";
                    return cellOrders;

                default:
                    var cellPackages = collectionView.DequeueReusableCell(CollectionHomePaqueteViewCell.Key, indexPath) as CollectionHomePaqueteViewCell;

                    var img = UIImage.FromBundle("Brandy");
                    cellPackages.BackgroundImage = img;
                    cellPackages.btnTitle = "Packtempedes";
                    return cellPackages;
            }





        }

        [Export("collectionView:layout:sizeForItemAtIndexPath:")]
        public CoreGraphics.CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            var paddingSpace = sectionInsets.Left * (itemsPerRow + 1);
            var availableWidth = View.Frame.Width - paddingSpace;
            var itemWidth = availableWidth / itemsPerRow;

            if (indexPath.Item >1)
            {
                availableWidth = View.Frame.Width - sectionInsets.Left;
                return new CoreGraphics.CGSize(availableWidth, itemWidth);
            }
            else{
                return new CoreGraphics.CGSize(itemWidth, itemWidth);
            }

        }

        [Export("numberOfSectionsInCollectionView:")]
        public nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 15;
        }
	}
}
