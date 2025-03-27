using EMR.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace EMR.Views.Pages
{
    public partial class StaffPage : INavigableView<StaffViewModel>
    {
        public StaffViewModel ViewModel { get; }

        public StaffPage(StaffViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
