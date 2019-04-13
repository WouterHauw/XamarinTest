using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace trainingrooms.droid
{
    [Activity(Label = "TrainingRoomDetailActivity")]
    public class TrainingRoomDetailActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.training_room_detail);

            int roomID = Intent.GetIntExtra("roomId", 0);
            var repo = new TrainingRooms.RoomReporsitory();
            var room = repo.GetRoom(roomID);

            this.Title = "Room Detail";
            this.FindViewById<TextView>(Resource.Id.txtName).Text = room.Name;
            this.FindViewById<TextView>(Resource.Id.txtLocation).Text = room.Location;

        }
    }
}