using System.Windows.Media;
using EMR.Models;
using EMR.interfaces;
using Wpf.Ui.Controls;


namespace EMR.ViewModels.Pages
{
    public partial class StaffViewModel : ObservableObject, INavigationAware
    {
        #region FIELDS

        private bool isInitialized = false;

        private readonly IDatabase<Staff?>? database;

        #endregion

        #region PROPERTIES

        [ObservableProperty]
        private IEnumerable<Staff?>? staffs;

        [ObservableProperty]
        private IEnumerable<string?>? name;

        [ObservableProperty]
        private int? selectedAge; 
        
        [ObservableProperty]
        private string? selectedName;

        [ObservableProperty]
        private int? selectedId;

        #endregion

        #region CONSTRUCTOR

        public StaffViewModel(IDatabase<Staff?>? database)
        {
            this.database = database;
        }

        #endregion

        #region COMMANDS

        [RelayCommand]
        private void OnSelectName()
        {
            var selectedData = this.selectedName;
        }

        [RelayCommand]
        private void UpdateData()
        {
            var data = this.database?.GetDetail(this.SelectedId);

            data.Name = this.SelectedName;
            data.Age = (int)this.SelectedAge;

            this.database?.Update(data);
        }

        [RelayCommand]
        private void DeleteData()
        {
            this.database?.Delete(this.SelectedId);
        }

        [RelayCommand]
        private void ReadDetailData()
        {
            var data = this.database?.GetDetail(this.SelectedId);

            this.SelectedName = data.Name;
            this.SelectedAge = data.Age;
        }

        [RelayCommand]
        private void CreateNewData()
        {
            Staff staff = new Staff();

            staff.Id = (int)this.SelectedId;

            staff.Name = this.SelectedName;

            staff.Age = (int)this.SelectedAge;

            this.database?.Create(staff);
        }

        [RelayCommand]
        private void ReadAllData()
        {
            this.Staffs = this.database?.Get();
        }

        #endregion

        #region METHOS
        public void OnNavigatedTo()
        {
            if (!isInitialized)
                InitializeViewModelAsync();
        }

        public void OnNavigatedFrom() { }


        [RelayCommand]
        private void OnSelectedName()
        {
            var selectedData = this.SelectedName;
        }


        private async Task InitializeViewModelAsync()
        {

            // 비동기로 데이터를 가져오기
            this.Staffs = await Task.Run(() => this.database?.Get());

            // 가져온 데이터를 가지고 필요한 작업 수행
            if (this.staffs != null)
            {
                this.Name = this.Staffs?.Select(c => c.Name).ToList();
            }

            isInitialized = true;
        }
        #endregion
    }
}
