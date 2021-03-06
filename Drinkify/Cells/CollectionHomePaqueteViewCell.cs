// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace Drinkify.Storyboards
{
	public partial class CollectionHomePaqueteViewCell : UICollectionViewCell
	{
        public static readonly NSString Key = new NSString(nameof(CollectionHomePaqueteViewCell));

        public string btnTitle
        {
            get => btnPackage.Title(UIControlState.Normal);
            set => btnPackage.SetTitle(value, UIControlState.Normal);

        }

        public UIImage BackgroundImage
        {
            get => imgBackground.Image;

            set => imgBackground.Image = value;


        }

		public CollectionHomePaqueteViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
