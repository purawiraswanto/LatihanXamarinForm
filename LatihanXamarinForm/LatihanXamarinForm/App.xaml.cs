using LatihanXamarinForm.DAL;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinForm
{
    public partial class App : Application
    {
        //singleton pattern
        private static DataAccess dbAccess;

        public static DataAccess DbAccess
        {
            get
            {
                if (dbAccess == null)
                    dbAccess = new DataAccess();
                return dbAccess;
            }
        }
        public App()
        {
            InitializeComponent();
            Application.Current.Properties["tempdata"] = string.Empty;

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new MyTabbedPage();
            //MainPage = new MyMasterDetailPage();
            //MainPage = new AddEmployeePage();
            MainPage = new NavigationPage(new ShowEmployeePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
