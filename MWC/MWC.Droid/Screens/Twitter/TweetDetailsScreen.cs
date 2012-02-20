using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Webkit;
using Android.Widget;
using MWC.BL;

namespace MWC.Android.Screens {
    [Activity(Label = "Tweet", ScreenOrientation = ScreenOrientation.Portrait)]
    public class TweetDetailsScreen : BaseScreen, MonoTouch.Dialog.Utilities.IImageUpdated {
        Tweet tweet;
        ImageView imageview;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.TweetDetailsScreen);

            var id = Intent.GetIntExtra("TweetID", -1);

            if (id >= 0) {
                tweet = BL.Managers.TwitterFeedManager.GetTweet(id);
                if (tweet != null) {
                    FindViewById<TextView>(Resource.Id.NameTextView).Text = tweet.RealName;
                    FindViewById<TextView>(Resource.Id.NameTextView).Click += (object sender, EventArgs e) => {
                        Intent browserIntent = new Intent(Intent.ActionView, global::Android.Net.Uri.Parse(tweet.AuthorUrl)); 
                        StartActivity(browserIntent);
                    };
                    FindViewById<TextView>(Resource.Id.HandleTextView).Text = tweet.FormattedAuthor;
                    FindViewById<TextView>(Resource.Id.HandleTextView).Click +=(object sender, EventArgs e) => {
                        Intent browserIntent = new Intent(Intent.ActionView, global::Android.Net.Uri.Parse(tweet.AuthorUrl)); 
                        StartActivity(browserIntent); 
                    };
                    FindViewById<TextView>(Resource.Id.TimeTextView).Text = tweet.FormattedTime;

                    // ugh - LoadData() method has problems when html contains a %
                    // http://code.google.com/p/android/issues/detail?id=1733
                    // http://code.google.com/p/android/issues/detail?id=4401
                    FindViewById<WebView>(Resource.Id.ContentWebView).LoadDataWithBaseURL(null,
                        "<html><body>" + tweet.Content + "</body></html>", @"text/html", "utf-8", null);
                    imageview = FindViewById<ImageView> (Resource.Id.TwitterImageView);

                    var uri = new Uri(tweet.ImageUrl);
                    Console.WriteLine("speaker.ImageUrl " + tweet.ImageUrl);
                    try {
                        var drawable = MonoTouch.Dialog.Utilities.ImageLoader.DefaultRequestImage(uri, this);
                        if (drawable != null)
                            imageview.SetImageDrawable(drawable);
                    } catch (Exception ex) {
                        Log.Debug("TWITTER", ex.ToString());
                    }
                } else {   // shouldn't happen...
                    FindViewById<TextView>(Resource.Id.TitleTextView).Text = "Tweet not found: " + id;
                }
            }
        }

       
        public void UpdatedImage(Uri uri)
        {
            RunOnUiThread(() => {
                var drawable = MonoTouch.Dialog.Utilities.ImageLoader.DefaultRequestImage(uri, this);
                imageview.SetImageDrawable(drawable);
            });
        }
    }
}