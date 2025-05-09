﻿using Syncfusion.Maui.Toolkit.Buttons;

namespace FitnessTracker
{
    public partial class TrackActivityMobile : ContentPage
    {
        List<string> activityList = new List<string>{ "Walking", "Running", "Cycling", "Swimming", "Yoga", "Sleeping" };
        public TrackActivityMobile()
        {
            InitializeComponent();
            activityBox.ItemsSource = activityList;
            activityBox.SelectedIndex = 0;
        }

        void Play_Clicked(object sender, EventArgs e)
        {
            beforeClick.IsVisible = false;
            afterClick.IsVisible = true;
        }

        void Stop_Clicked(object sender, EventArgs e)
        {
            beforeClick.IsVisible = true;
            afterClick.IsVisible = false;
        }

        void CloseIcon_Tapped(object sender, TappedEventArgs e)
        {
            Navigation.PopAsync();
        }

        void Pause_Clicked(object sender, EventArgs e)
        {
            if(sender is SfButton button)
            {
                button.Text = (button.Text == "\ue70e") ? "\ue70f" : "\ue70e";
            }
        }
    }
}