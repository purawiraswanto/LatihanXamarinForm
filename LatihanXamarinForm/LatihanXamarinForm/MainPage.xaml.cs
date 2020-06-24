using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace LatihanXamarinForm
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSimpleList_Clicked(object sender , EventArgs e)
        {
            await Navigation.PushAsync(new ContohListString());
        }

        private async void btnBindingList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohBindingModelList());
        }

        private async void btnImageList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohImageList());
        }

        private async void menuAbsolut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohAbsoluteLayout());
        }

        private async void menuGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohGridLayout());
        }

        private async void menuCalc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohKalkulatorPage());
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Save Photo?", "Cancel", "Delete", "Photo Roll", "email", "WhatsApp");
            await DisplayAlert("Keterangan", $"Anda memilih: {action}", "OK");
        }

        private async void btnPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("language", entryLanguage.Text);
            await DisplayAlert("Keterangan", $"Preference {entryLanguage.Text} sudah dibuat", "OK");
        }

        private async void btnAmbilPreference_Clicked(object sender, EventArgs e)
        {
            var data = Preferences.Get("language", "");
            await DisplayAlert("Keterangan", $"Preferences: {data}", "OK");
        }
        private void Label_ChildrenReordered(object sender, EventArgs e)
        {

        }
    }
}
