using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR.Models;
using EMR.interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Wpf.Ui.Controls;

namespace EMR.ViewModels.Pages
{
    public partial class StaffViewModel : ObservableObject, INavigationAware
    {
        #region FIELDS

        private bool isInitialized = false;
        private readonly IDatabase<Staff> database;

        #endregion

        #region PROPERTIES

        [ObservableProperty]
        private IEnumerable<Staff> staffs;

        [ObservableProperty]
        private Staff selectedStaff;

        #endregion

        #region CONSTRUCTOR

        public StaffViewModel(IDatabase<Staff> database)
        {
            this.database = database;
        }

        #endregion

        #region COMMANDS

        [RelayCommand]
        private void OnSelectName(Staff selectedStaff)
        {
            this.SelectedStaff = selectedStaff;
        }

        [RelayCommand]
        private void UpdateData()
        {
            if (this.SelectedStaff != null)
            {
                var data = this.database.GetDetail(this.SelectedStaff.Id);

                data.Name = this.SelectedStaff.Name;
                data.Age = this.SelectedStaff.Age;
                data.Department = this.SelectedStaff.Department;  // 추가된 속성
                data.Position = this.SelectedStaff.Position;      // 추가된 속성
                data.Email = this.SelectedStaff.Email;            // 추가된 속성
                data.Phone = this.SelectedStaff.Phone;            // 추가된 속성
                //data.UserImg = this.SelectedStaff.UserImg;        // 추가된 속성

                this.database.Update(data);
            }
        }

        [RelayCommand]
        private void DeleteData()
        {
            if (this.SelectedStaff != null)
            {
                this.database.Delete(this.SelectedStaff.Id);
            }
        }

        [RelayCommand]
        private void ReadDetailData()
        {
            if (this.SelectedStaff != null)
            {
                var data = this.database.GetDetail(this.SelectedStaff.Id);

                this.SelectedStaff.Name = data.Name;
                this.SelectedStaff.Age = data.Age;
                this.SelectedStaff.Department = data.Department;  // 추가된 속성
                this.SelectedStaff.Position = data.Position;      // 추가된 속성
                this.SelectedStaff.Email = data.Email;            // 추가된 속성
                this.SelectedStaff.Phone = data.Phone;            // 추가된 속성
                //this.SelectedStaff.UserImg = data.UserImg;        // 추가된 속성
            }
        }

        [RelayCommand]
        private void CreateNewData()
        {
            if (this.SelectedStaff != null)
            {
                Staff staff = new Staff
                {
                    Name = this.SelectedStaff.Name,
                    Age = this.SelectedStaff.Age,
                    Department = this.SelectedStaff.Department,  // 추가된 속성
                    Position = this.SelectedStaff.Position,      // 추가된 속성
                    Email = this.SelectedStaff.Email,            // 추가된 속성
                    Phone = this.SelectedStaff.Phone,            // 추가된 속성
                    //UserImg = this.SelectedStaff.UserImg         // 추가된 속성
                };

                this.database.Create(staff);
            }
        }

        [RelayCommand]
        private void ReadAllData()
        {
            this.Staffs = this.database.Get();
        }

        #endregion

        #region METHODS

        public void OnNavigatedTo()
        {
            if (!isInitialized)
                InitializeViewModelAsync();
        }

        public void OnNavigatedFrom() { }

        private async Task InitializeViewModelAsync()
        {
            this.Staffs = await Task.Run(() => this.database.Get());

    
            isInitialized = true;
        }

        #endregion
    }
}