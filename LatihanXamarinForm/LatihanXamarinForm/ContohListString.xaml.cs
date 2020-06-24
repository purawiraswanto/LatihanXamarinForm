using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContohListString : ContentPage
    {
        public ContohListString()
        {
            InitializeComponent();
            List<string> items = new List<string>
            {
                "Pura",
                "Nuke",
                "Ranu",
                "Dito",
                "Kea"
            };
            lvData.ItemsSource = items;
            
        }

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string nama = e.Item.ToString();
            ContohAmbilInput formContohAmbilInput = new ContohAmbilInput(nama);
            await Navigation.PushAsync(formContohAmbilInput);
            //await DisplayAlert("Keterangan", $"Anda memilih nama: {nama}", "OK");

        }
    }
}