using System;
using LatihanXamarinForm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditEmployeePage : ContentPage
    {
        public EditEmployeePage()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var editEmp = new Employee
            {
                EmpId = Convert.ToInt64(entryID.Text),
                EmpName = entryName.Text,
                Department = entryDepartment.Text,
                Designation = entryDesignation.Text,
                Qualification = entryQualification.Text
            };
            try
            {
                App.DbAccess.EditEmployee(editEmp);
                await DisplayAlert("Keterangan", $"Data employee {editEmp.EmpName} berhasil diedit", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", ex.Message, "OK");
            }
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var delEmployee = new Employee
            {
                EmpId = Convert.ToInt64(entryID.Text)
            };

            var result = await DisplayAlert("Konfirmasi",
                $"Apakah anda yakin akan delete data?", "Yes", "No");
            if (result)
            {
                App.DbAccess.DeleteEmployee(delEmployee);
                await DisplayAlert("Keterangan", "Data berhasil didelete", "OK");
                await Navigation.PopAsync();
            }
        }


    }
}