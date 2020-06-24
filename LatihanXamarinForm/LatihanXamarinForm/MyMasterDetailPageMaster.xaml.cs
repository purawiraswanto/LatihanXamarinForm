using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public MyMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterDetailPageMasterMenuItem>(new[]
                {
                    new MyMasterDetailPageMasterMenuItem { Id = 0, Title = "Home", TargetType=typeof(MainPage)},
                    new MyMasterDetailPageMasterMenuItem { Id = 1, Title = "Simple Calc", TargetType=typeof(ContohGridLayout)},
                    new MyMasterDetailPageMasterMenuItem { Id = 2, Title = "Image List", TargetType=typeof(ContohImageList) },
                    new MyMasterDetailPageMasterMenuItem { Id = 3, Title = "Contoh Tab", TargetType=typeof(MyTabbedPage) },
                    new MyMasterDetailPageMasterMenuItem { Id = 4, Title = "Custom List", TargetType=typeof(ContohCustomList)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}