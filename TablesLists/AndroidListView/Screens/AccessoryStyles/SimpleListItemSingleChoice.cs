﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TablesAndCellStyles {
    [Activity(Label = "SimpleListItemSingleChoice")]
    public class SimpleListItemSingleChoice : ListActivity {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            string[] items = new string[] { "Option 1", "Option 2", "Option 3" };

            ListAdapter = new ArrayAdapter<String> (this, Android.Resource.Layout.SimpleListItemSingleChoice, items);

            ListView lv = FindViewById<ListView>(Android.Resource.Id.List);
            lv.ChoiceMode = Android.Widget.ChoiceMode.Single;
        }
    }
}
/*
<CheckedTextView xmlns:android="http://schemas.android.com/apk/res/android" android:id="@android:id/text1" android:layout_width="fill_parent" android:layout_height="?android:attr/listPreferredItemHeight" android:textAppearance="?android:attr/textAppearanceLarge" android:gravity="center_vertical" android:checkMark="?android:attr/listChoiceIndicatorSingle" android:paddingLeft="6dip" android:paddingRight="6dip" /> 
 */

