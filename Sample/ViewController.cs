using System;
using PopupController;
using UIKit;
using CoreGraphics;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		partial void BtnFormSheetTouchUpInside(UIButton sender)
		{
			CNPPopupController controller = new CNPPopupController(new UIView[] { GenerateView() });
			controller.Delegate = new MyControllerDelegate();
			var theme = new CNPPopupTheme();
			theme.PopupStyle = CNPPopupStyle.ActionSheet;
			theme.PresentationStyle = CNPPopupPresentationStyle.SlideInFromTop;
			theme.MaskType = CNPPopupMaskType.Dimmed;
			theme.BackgroundColor = UIColor.White;
			theme.AnimationDuration = 1f;
			theme.MaxPopupWidth = this.View.Bounds.Width;
			theme.ShouldDismissOnBackgroundTouch = true;
			controller.Theme = theme;
			controller.PresentPopupControllerAnimated(true);
		}

		partial void BtnPopupCenteredTouchUpInside(UIButton sender)
		{
			CNPPopupController controller = new CNPPopupController(new UIView[] { GenerateView() });
			controller.Delegate = new MyControllerDelegate();
			var theme = new CNPPopupTheme();
			theme.PopupStyle = CNPPopupStyle.Centered;
			theme.PresentationStyle = CNPPopupPresentationStyle.SlideInFromTop;
			theme.MaskType = CNPPopupMaskType.Dimmed;
			theme.BackgroundColor = UIColor.White;
			theme.AnimationDuration = 1f;
			theme.MaxPopupWidth = this.View.Bounds.Width;
			theme.ShouldDismissOnBackgroundTouch = true;
			controller.Theme = theme;
			controller.PresentPopupControllerAnimated(true);
		}

		partial void BtnPopupFullScreenTouchUpInside(UIButton sender)
		{
			CNPPopupController controller = new CNPPopupController(new UIView[] { GenerateView() });
			controller.Delegate = new MyControllerDelegate();
			var theme = new CNPPopupTheme();
			theme.PopupStyle = CNPPopupStyle.Fullscreen;
			theme.PresentationStyle = CNPPopupPresentationStyle.SlideInFromTop;
			theme.MaskType = CNPPopupMaskType.Dimmed;
			theme.BackgroundColor = UIColor.White;
			theme.AnimationDuration = 1f;
			theme.MaxPopupWidth = this.View.Bounds.Width;
			theme.ShouldDismissOnBackgroundTouch = true;
			controller.Theme = theme;
			controller.PresentPopupControllerAnimated(true);
		}

		private UIView GenerateView()
		{
			var headerLabel = new UILabel(new CGRect(0, 0, 100, 40));
			headerLabel.Text = "Testing";
			headerLabel.BackgroundColor = UIColor.Clear;
			headerLabel.TextAlignment = UITextAlignment.Center;
			headerLabel.Font = UIFont.SystemFontOfSize(12);
			headerLabel.TextColor = UIColor.FromRGB(80, 80, 80);
			return headerLabel;
		}
	}

	public class MyControllerDelegate : CNPPopupControllerDelegate
	{

	}
}
