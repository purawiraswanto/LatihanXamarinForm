using LatihanXamarinForm.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployeePage : ContentPage
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private async void btnTambah_Clicked(object sender, EventArgs e)
        {
            var newEmployee = new Employee
            {
                EmpName = entryName.Text,
                Designation = entryDesignation.Text,
                Department = entryDepartment.Text,
                Qualification = entryQualification.Text
            };

            try
            {
                App.DbAccess.InsertEmployee(newEmployee);
                await DisplayAlert("Keterangan",
                    $"Data Employee {newEmployee.EmpName} berhasil ditambah", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}