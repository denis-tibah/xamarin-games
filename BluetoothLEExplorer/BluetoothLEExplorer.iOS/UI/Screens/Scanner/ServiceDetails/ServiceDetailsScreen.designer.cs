// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace BluetoothLEExplorer.iOS.UI.Screens.Scanner.ServiceDetails
{
	partial class ServiceDetailsScreen
	{
		[Outlet]
		MonoTouch.UIKit.UITableView CharacteristicsTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CharacteristicsTable != null) {
				CharacteristicsTable.Dispose ();
				CharacteristicsTable = null;
			}
		}
	}
}
