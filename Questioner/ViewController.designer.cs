// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Questioner
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField hodnotaA { get; set; }

		[Outlet]
		AppKit.NSTextField hodnotaB { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator levl { get; set; }

		[Outlet]
		AppKit.NSTextField operace { get; set; }

		[Outlet]
		AppKit.NSTextField textvis1 { get; set; }

		[Outlet]
		AppKit.NSTextField textvis2 { get; set; }

		[Action ("textsend1:")]
		partial void textsend1 (Foundation.NSObject sender);

		[Action ("textsend2:")]
		partial void textsend2 (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (hodnotaA != null) {
				hodnotaA.Dispose ();
				hodnotaA = null;
			}

			if (hodnotaB != null) {
				hodnotaB.Dispose ();
				hodnotaB = null;
			}

			if (levl != null) {
				levl.Dispose ();
				levl = null;
			}

			if (operace != null) {
				operace.Dispose ();
				operace = null;
			}

			if (textvis1 != null) {
				textvis1.Dispose ();
				textvis1 = null;
			}

			if (textvis2 != null) {
				textvis2.Dispose ();
				textvis2 = null;
			}
		}
	}
}
