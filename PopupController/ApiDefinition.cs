using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace PopupController
{
	// @interface CNPPopupController : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CNPPopupController
	{
		// @property (nonatomic, strong) CNPPopupTheme * _Nonnull theme;
		[Export("theme", ArgumentSemantic.Strong)]
		CNPPopupTheme Theme { get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		CNPPopupControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<CNPPopupControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithContents:(NSArray<UIView *> * _Nonnull)contents __attribute__((objc_designated_initializer));
		[Export("initWithContents:")]
		[DesignatedInitializer]
		IntPtr Constructor(UIView[] contents);

		// -(void)presentPopupControllerAnimated:(BOOL)flag;
		[Export("presentPopupControllerAnimated:")]
		void PresentPopupControllerAnimated(bool flag);

		// -(void)dismissPopupControllerAnimated:(BOOL)flag;
		[Export("dismissPopupControllerAnimated:")]
		void DismissPopupControllerAnimated(bool flag);
	}

	// @protocol CNPPopupControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface CNPPopupControllerDelegate
	{
		// @optional -(void)popupControllerWillPresent:(CNPPopupController * _Nonnull)controller;
		[Export("popupControllerWillPresent:")]
		void PopupControllerWillPresent(CNPPopupController controller);

		// @optional -(void)popupControllerDidPresent:(CNPPopupController * _Nonnull)controller;
		[Export("popupControllerDidPresent:")]
		void PopupControllerDidPresent(CNPPopupController controller);

		// @optional -(void)popupControllerWillDismiss:(CNPPopupController * _Nonnull)controller;
		[Export("popupControllerWillDismiss:")]
		void PopupControllerWillDismiss(CNPPopupController controller);

		// @optional -(void)popupControllerDidDismiss:(CNPPopupController * _Nonnull)controller;
		[Export("popupControllerDidDismiss:")]
		void PopupControllerDidDismiss(CNPPopupController controller);
	}

	// typedef void (^SelectionHandler)(CNPPopupButton * _Nonnull);
	delegate void SelectionHandler(CNPPopupButton arg0);

	// @interface CNPPopupButton : UIButton
	[BaseType(typeof(UIButton))]
	interface CNPPopupButton
	{
		// @property (copy, nonatomic) SelectionHandler _Nullable selectionHandler;
		[NullAllowed, Export("selectionHandler", ArgumentSemantic.Copy)]
		SelectionHandler SelectionHandler { get; set; }
	}

	// @interface CNPPopupTheme : NSObject
	[BaseType(typeof(NSObject))]
	interface CNPPopupTheme
	{
		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets popupContentInsets;
		[Export("popupContentInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets PopupContentInsets { get; set; }

		// @property (assign, nonatomic) CNPPopupStyle popupStyle;
		[Export("popupStyle", ArgumentSemantic.Assign)]
		CNPPopupStyle PopupStyle { get; set; }

		// @property (assign, nonatomic) CNPPopupPresentationStyle presentationStyle;
		[Export("presentationStyle", ArgumentSemantic.Assign)]
		CNPPopupPresentationStyle PresentationStyle { get; set; }

		// @property (assign, nonatomic) CNPPopupMaskType maskType;
		[Export("maskType", ArgumentSemantic.Assign)]
		CNPPopupMaskType MaskType { get; set; }

		// @property (assign, nonatomic) BOOL dismissesOppositeDirection;
		[Export("dismissesOppositeDirection")]
		bool DismissesOppositeDirection { get; set; }

		// @property (assign, nonatomic) BOOL shouldDismissOnBackgroundTouch;
		[Export("shouldDismissOnBackgroundTouch")]
		bool ShouldDismissOnBackgroundTouch { get; set; }

		// @property (assign, nonatomic) BOOL movesAboveKeyboard;
		[Export("movesAboveKeyboard")]
		bool MovesAboveKeyboard { get; set; }

		// @property (assign, nonatomic) CGFloat contentVerticalPadding;
		[Export("contentVerticalPadding")]
		nfloat ContentVerticalPadding { get; set; }

		// @property (assign, nonatomic) CGFloat maxPopupWidth;
		[Export("maxPopupWidth")]
		nfloat MaxPopupWidth { get; set; }

		// @property (assign, nonatomic) CGFloat animationDuration;
		[Export("animationDuration")]
		nfloat AnimationDuration { get; set; }

		// +(CNPPopupTheme * _Nonnull)defaultTheme;
		[Static]
		[Export("defaultTheme")]
		CNPPopupTheme DefaultTheme { get; }
	}
}
