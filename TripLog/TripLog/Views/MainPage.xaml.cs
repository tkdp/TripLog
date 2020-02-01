﻿using System;
using TripLog.Models;
using TripLog.ViewModels;
using Xamarin.Forms;

namespace TripLog.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private void New_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEntryPage());
        }

        private async void Trips_Tapped(object sender, ItemTappedEventArgs e)
        {
            var trip = (TripLogEntry) e.Item;
            await Navigation.PushAsync(new DetailPage(trip));

            // Clear selection
            trips.SelectedItem = null;
        }
    }
}