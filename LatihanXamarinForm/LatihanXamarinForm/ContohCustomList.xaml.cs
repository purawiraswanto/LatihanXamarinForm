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
    public partial class ContohCustomList : ContentPage
    {
        private List<ListItem> lstItems;
        public ContohCustomList()
        {
            InitializeComponent();
            lstItems = new List<ListItem>
            {
                new ListItem { Title = "Xamarin Android", Price="10", Description = "Xamarin with traditional Android UI", Source= "Monkey1.png"},
                new ListItem { Title = "Xamarin iOS", Price="20",  Description = "Xamarin with traditional iOS UI", Source= "Monkey2.png" },
                new ListItem { Title = "Xamarin Forms", Price="50",  Description = "Cross Platform Xamarin with traditional Forms", Source= "Monkey3.png" }
            };
            lvImage.ItemsSource = lstItems;
        }
    }
}