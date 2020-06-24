using LatihanXamarinForm.Models;
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
    public partial class ContohImageList : ContentPage
    {
        private List<ListItem> lstItems;
        public ContohImageList()
        {
            InitializeComponent();
            lstItems = new List<ListItem>
            {
                new ListItem { Title = "Xamarin Android", Description = "Xamarin with traditional Android UI", Source= "Monkey1.png"},
                new ListItem { Title = "Xamarin iOS", Description = "Xamarin with traditional iOS UI", Source= "Monkey2.png" },
                new ListItem { Title = "Xamarin Forms", Description = "Cross Platform Xamarin with traditional Forms", Source= "Monkey3.png" }
            };
            lvImage.ItemsSource = lstItems;
        }

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem data = (ListItem)e.Item;
            await DisplayAlert("Keterangan", $"Anda memilih nama: {data.Title}", "OK");

        }
    }
}