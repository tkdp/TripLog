using System;
using TripLog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEntryPage : ContentPage
    {
        public NewEntryPage()
        {
            InitializeComponent();
            BindingContext = new NewEntryViewModel();
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}