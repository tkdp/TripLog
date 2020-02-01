using TripLog.Models;

namespace TripLog.ViewModels
{
    public class DetailViewsModel : BaseViewModel
    {
        private TripLogEntry _entry;

        public DetailViewsModel(TripLogEntry entry)
        {
            Entry = entry;
        }

        public TripLogEntry Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged();
            }
        }
    }
}