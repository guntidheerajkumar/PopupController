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

namespace Sample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnFormSheet { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnPopupCentered { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnPopupFullScreen { get; set; }

        [Action ("BtnFormSheetTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnFormSheetTouchUpInside (UIKit.UIButton sender);

        [Action ("BtnPopupCenteredTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPopupCenteredTouchUpInside (UIKit.UIButton sender);

        [Action ("BtnPopupFullScreenTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPopupFullScreenTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtnFormSheet != null) {
                BtnFormSheet.Dispose ();
                BtnFormSheet = null;
            }

            if (BtnPopupCentered != null) {
                BtnPopupCentered.Dispose ();
                BtnPopupCentered = null;
            }

            if (BtnPopupFullScreen != null) {
                BtnPopupFullScreen.Dispose ();
                BtnPopupFullScreen = null;
            }
        }
    }
}