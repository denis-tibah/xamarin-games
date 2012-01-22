using System;
using System.Collections.Generic;
using Android.Widget;
using MWC.BL;
using Android.App;
using MWC;
using Android.Views;
using System.Linq;

namespace MWC.Adapters
{
    /// <remarks>
    /// <seealso cref="MWC.Adapters.SessionTimeslotListAdapter"/> and the iOS FavoritesScreen
    /// </remarks>
    public class FavoritesListAdapter : BaseAdapter<Session>
    {
        protected Activity _context = null;
        
        private readonly IList<object> _rows;

        public FavoritesListAdapter(Activity context, IList<Favorite> favorites, IList<Session> allSessions)
            : base()
        {
            this._context = context;
           
            List<string> favoriteIDs = new List<string>();
			foreach (var f in favorites) favoriteIDs.Add (f.SessionKey);

            var timeslots = from s in allSessions
							where favoriteIDs.Contains(s.Key)
							group s by s.Start.Ticks into g
							orderby g.Key
							select new SessionTimeslot
                                (new DateTime (g.Key).ToString ("dddd HH:mm")
                                   , from hs in g select hs);

            this._rows = new List<object>();
            // flatten groups into single 'list'
            foreach (var time in timeslots)
            {
                _rows.Add(time.Timeslot);
                foreach (var session in time.Sessions)
                {
                    _rows.Add(session);
                }
            }
        }

        public override Session this[int position]
        {
            get
            { // this'll break if called with a 'header' position
                return (Session)this._rows[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return this._rows.Count; }
        }

        /// <summary>
        /// Grouped list: view could be a 'section heading' or a 'data row'
        /// </summary>
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // Get our object for this position
            var item = this._rows[position];
            View view = null;

            if (item is string)
            {   // header
                view = _context.LayoutInflater.Inflate(Resource.Layout.SessionTimeslotListItem, null);
                view.Clickable = false;
                view.LongClickable = false;
                view.SetOnClickListener(null);

                view.FindViewById<TextView>(Resource.Id.TitleTextView).Text = (string)item;
            }
            else
            {   //session
                view = _context.LayoutInflater.Inflate(Resource.Layout.SessionListItem, null);

                // Find references to each subview in the list item's view
                var _titleTextView = view.FindViewById<TextView>(Resource.Id.TitleTextView);
                var _roomTextView = view.FindViewById<TextView>(Resource.Id.RoomTextView);

                var session = (Session)item;
                //Assign this item's values to the various subviews
                _titleTextView.SetText(session.Title, TextView.BufferType.Normal);
                _roomTextView.SetText(session.Room, TextView.BufferType.Normal);
            }
            //Finally return the view
            return view;
        }
    }
}

