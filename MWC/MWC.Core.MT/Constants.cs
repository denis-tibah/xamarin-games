using System;
using System.Collections.Generic;

namespace MWC {
	public class Constants {

		public Constants ()
		{
		}
		
		public static DateTime StartDateMin = new DateTime ( 2012, 02, 27, 0, 0, 0 );
		public static DateTime EndDateMax = new DateTime ( 2012, 03, 1, 23, 59, 59 );

		public const string NewsBaseUrl = "news.google.com"; // for Reachability test
		public const string NewsUrl = "http://news.google.com/news?q=mobile%20world%20congress&output=rss";
		public const string TwitterUrl = "http://search.twitter.com/search.atom?q=%40mobileworldlive&show-user=true&rpp=30&result-type=recent";
		
		public const string ConferenceDataBaseUrl = "mwc.xamarin.com";
		public const string ConferenceDataUrl = "http://mwc.xamarin.com/conference.xml";
		public const string ExhibitorDataUrl = "http://mwc.xamarin.com/exhibitors.xml";

		public const float MapPinLatitude = 41.374377f;
		public const float MapPinLongitude = 2.152226f;
		public const string MapPinTitle = "Mobile World Congress 2012";
		public const string MapPinSubtitle = "Fira de Barcelona";
	}
}