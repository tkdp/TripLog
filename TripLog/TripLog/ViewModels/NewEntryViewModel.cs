using System;
using TripLog.Models;
using Xamarin.Forms;

namespace TripLog.ViewModels
{
    public class NewEntryViewModel : BaseViewModel
    {
        private DateTime _date;

        private double _latitude;

        private double _longitude;

        private string _notes;

        private int _rating;

        private Command _saveCommand;
        private string _title;

        public NewEntryViewModel()
        {
            Date = DateTime.Today;
            Rating = 1;
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
                SaveCommand.ChangeCanExecute();
            }
        }

        public double Latitude
        {
            get => _latitude;
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }
        }

        public double Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public int Rating
        {
            get => _rating;
            set
            {
                _rating = value;
                OnPropertyChanged();
            }
        }

        public string Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand => _saveCommand ?? (_saveCommand = new Command(ExecuteSaveCommand, CanSave));


        private void ExecuteSaveCommand()
        {
            var newItem = new TripLogEntry
            {
                Title = Title,
                Latitude = Latitude,
                Longitude = Longitude,
                Date = Date, Rating = Rating,
                Notes = Notes
            };
        }

        private bool CanSave()
        {
            return !string.IsNullOrWhiteSpace(Title);
        }
    }
}