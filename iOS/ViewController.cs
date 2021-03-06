﻿using System;

using UIKit;
using Foundation;

namespace XamarinTest.iOS
{
	public partial class ViewController : UIViewController
	{
		partial void UIButton3_TouchUpInside(UIButton sender)
		{
			Console.WriteLine("Button clicked");
		}

		int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				var title = string.Format("{0} clicks!", count++);
				Button.SetTitle(title, UIControlState.Normal);
			};
			this.newLabel.Text = "Hi this is me";
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}


		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

	

			//Set up Destination View Controller
			if (segue.Identifier == "nextSegue")
			{
				var itvc = (MyViewController)segue.DestinationViewController;
				if (itvc != null)
				{
					itvc.labelTPass = "New label";

				}
			}


		}


	}
}
