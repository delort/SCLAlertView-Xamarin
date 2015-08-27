// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SCLAlertViewSample
{
	[Register ("DataViewController")]
	partial class DataViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SuccessButton { get; set; }

		[Action ("ShowCustom:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowCustom (UIButton sender);

		[Action ("ShowEdit:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowEdit (UIButton sender);

		[Action ("ShowError:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowError (UIButton sender);

		[Action ("ShowInfo:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowInfo (UIButton sender);

		[Action ("ShowNotice:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowNotice (UIButton sender);

		[Action ("ShowSuccess:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowSuccess (UIButton sender);

		[Action ("ShowWaiting:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowWaiting (UIButton sender);

		[Action ("ShowWarning:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowWarning (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (dataLabel != null) {
				dataLabel.Dispose ();
				dataLabel = null;
			}
			if (SuccessButton != null) {
				SuccessButton.Dispose ();
				SuccessButton = null;
			}
		}
	}
}
