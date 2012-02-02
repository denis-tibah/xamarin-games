using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MWC.BL;

namespace MWC.iOS.UI.CustomElements {
	/// <summary>
	/// Speaker element.
	/// on iPhone, pushes via MT.D
	/// on iPad, sends view to SplitViewController
	/// </summary>
	public class SpeakerElement : Element  {
		static NSString cellId = new NSString ("SpeakerElement");
		Speaker speaker;

		/// <summary>If this is null, on iPhone; otherwise on iPad</summary>
		MWC.iOS.Screens.iPad.Speakers.SpeakerSplitView splitView;
		
		/// <summary>for iPhone</summary>
		public SpeakerElement (Speaker showSpeaker) : base (showSpeaker.Name)
		{
			speaker = showSpeaker;
		}
		/// <summary>for iPad (SplitViewController)</summary>
		public SpeakerElement (Speaker showSpeaker, MWC.iOS.Screens.iPad.Speakers.SpeakerSplitView speakerSplitView) : base (showSpeaker.Name)
		{
			speaker = showSpeaker;
			splitView = speakerSplitView;
		}
		
		static int count;
		public override UITableViewCell GetCell (UITableView tv)
		{
			var cell = tv.DequeueReusableCell (cellId);
			count++;
			if (cell == null)
				cell = new SpeakerCell (UITableViewCellStyle.Subtitle, cellId, speaker);
			else
				((SpeakerCell)cell).UpdateCell (speaker);

			return cell;
		}
		
		/// <summary>
		/// Behaves differently depending on iPhone or iPad
		/// </summary>
		public override void Selected (DialogViewController dvc, UITableView tableView, MonoTouch.Foundation.NSIndexPath path)
		{
			if (splitView != null)
				splitView.ShowSpeaker (speaker.ID);
			else {
				var sds = new MWC.iOS.Screens.iPhone.Speakers.SpeakerDetailsScreen (speaker.ID);
				dvc.ActivateController (sds);
			}
		}
	}
}