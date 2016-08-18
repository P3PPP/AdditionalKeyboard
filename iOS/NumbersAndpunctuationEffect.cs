using System;
using AdditionalKeyboard.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName ("AdditionalKeyboard")]
[assembly: ExportEffect (typeof (NumbersAndpunctuationEffect), "NumbersAndpunctuationEffect")]

namespace AdditionalKeyboard.iOS
{
	public class NumbersAndpunctuationEffect : PlatformEffect
	{
		protected override void OnAttached ()
		{
			var textInput = Control as IUITextInput;
			if (textInput == null)
				return;

			textInput.KeyboardType = UIKeyboardType.NumbersAndPunctuation;
		}

		protected override void OnDetached ()
		{
		}
	}
}

