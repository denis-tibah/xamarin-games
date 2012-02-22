using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using MWC.BL;

namespace MWC.Android.Screens {
    [Activity(Label = "Session", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SessionDetailsScreen : BaseScreen {
        Session session;
        bool isFavorite = false;
        Button favoriteButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.SessionDetailsScreen);

            favoriteButton = FindViewById<Button>(Resource.Id.FavouriteButton);
            favoriteButton.Click += new EventHandler(_favouriteButton_Click);

            var id = Intent.GetIntExtra("SessionID", -1);

            if (id >= 0) {
                session = BL.Managers.SessionManager.GetSession(id);
                if (session != null) {
                    FindViewById<TextView>(Resource.Id.TitleTextView).Text = session.Title;
                    FindViewById<TextView>(Resource.Id.SpeakersTextView).Text = session.SpeakerNames;
                    FindViewById<TextView>(Resource.Id.DateTimeTextView).Text = session.Start.ToString("dddd H:mm")
                                                                    + " - " + session.End.ToString("H:mm");

                    var roomTextView = FindViewById<TextView>(Resource.Id.RoomTextView); 
                    var roomPanel = FindViewById<LinearLayout>(Resource.Id.RoomPanel);
                    if (String.IsNullOrEmpty(session.Room)) {
                        roomPanel.Visibility = ViewStates.Gone;
                    }  else {
                        roomPanel.Visibility = ViewStates.Visible;
                        roomTextView.SetText(session.Room, TextView.BufferType.Normal);
                    }


                    FindViewById<TextView>(Resource.Id.OverviewTextView).Text = session.Overview;

                    isFavorite = BL.Managers.FavoritesManager.IsFavorite(session.Key);

                    if (isFavorite) {
                        favoriteButton.SetBackgroundResource(Resource.Drawable.star_gold_selector);
                    } else {
                        favoriteButton.SetBackgroundResource(Resource.Drawable.star_grey_selector);
                    }
                } else {   // shouldn't happen...
                    FindViewById<TextView>(Resource.Id.TitleTextView).Text = "Session not found: " + id;
                }
            }
        }


        void _favouriteButton_Click(object sender, EventArgs e)
        {
            isFavorite = !isFavorite;

            if (isFavorite) {
                favoriteButton.SetBackgroundResource(Resource.Drawable.star_gold_selector);
                var fav = new Favorite { SessionID = session.ID, SessionKey = session.Key };
                BL.Managers.FavoritesManager.AddFavoriteSession(fav);
            } else {
                favoriteButton.SetBackgroundResource(Resource.Drawable.star_grey_selector);
                BL.Managers.FavoritesManager.RemoveFavoriteSession(session.Key);
            }   
        }
    }
}