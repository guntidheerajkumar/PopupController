using System;

namespace PopupController
{
	public enum CNPPopupStyle : int
	{
		ActionSheet = 0,
		Centered,
		Fullscreen
	}

	public enum CNPPopupPresentationStyle : int
	{
		FadeIn = 0,
		SlideInFromTop,
		SlideInFromBottom,
		SlideInFromLeft,
		SlideInFromRight
	}

	public enum CNPPopupMaskType : int
	{
		Clear,
		Dimmed
	}
}