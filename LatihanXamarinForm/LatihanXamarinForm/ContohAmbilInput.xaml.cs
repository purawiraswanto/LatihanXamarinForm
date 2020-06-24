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
    public partial class ContohAmbilInput : ContentPage
    {
        public ContohAmbilInput()
        {
            InitializeComponent();


        }

        //Overloading Constructor
        public ContohAmbilInput(string nama)
        {
            InitializeComponent();

            lblInput.Text = $"Input dari form lain:{nama}";
        }
    }
}