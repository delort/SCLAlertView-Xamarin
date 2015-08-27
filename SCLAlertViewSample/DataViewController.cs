using System;
using UIKit;
using SCLAlertViewLib;

namespace SCLAlertViewSample
{
	public partial class DataViewController : UIViewController
	{
		public string DataObject {
			get;
			set;
		}

		public DataViewController (IntPtr handle) : base (handle)
		{
		}

		partial void ShowSuccess (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowSuccess(this, "Hello World", "This is a more descriptive text.", "Done", 0);
		}

		partial void ShowError (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowError(this, "Hello Error", "This is a more descriptive error text.", "OK", 0);
		}

		partial void ShowNotice (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowNotice(this, "Hello Notice", "This is a more descriptive notice text.", "OK", 0);
		}

		partial void ShowWarning (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowWarning(this, "Hello Warning", "This is a more descriptive warning text.", "OK", 0);
		}

		partial void ShowInfo (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowInfo(this, "Hello Info", "This is a more descriptive info text.", "OK", 0);
		}

		partial void ShowEdit (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowEdit(this, "Hello Edit", "This is a more descriptive text with edit textbox.", "OK", 0);
		}

		partial void ShowCustom (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowCustom(this, new UIImage("git.png"), UIColor.Purple, "Custom", "I'm with custom image and color", "OK", 0);
		}

		partial void ShowWaiting (UIButton sender)
		{
			SCLAlertView alert = new SCLAlertView();
			alert.ShowWaiting(this, "Waiting", "Continue waittttttinggggg...", null, 5.0);
		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			dataLabel.Text = DataObject;
		}
	}
}

