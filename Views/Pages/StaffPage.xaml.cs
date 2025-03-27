using System.Windows.Controls;
using EMR.ViewModels.Pages;
using Wpf.Ui.Controls;
using WpfApp1.Models;

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
        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {



            List<User> myList1 = new List<User>();


            User userA = new User();

            //userA.UserImg = @"C:\\Users\\idodo\\Documents\\Study2_C\\개발자 Park\\WpfApp\\WpfApp1\\WpfApp1\\Resources\\cat.jpg";
            userA.UserImg = "pack://application:,,,/Resources/cat.jpg";
            //userA.UserImg = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "cat.jpg"); 
            userA.Name = "hada";
            userA.UserAge = 15;

            User userB = new User();

           
            userB.UserImg = "pack://application:,,,/Resources/bird.jpg"; 
            userB.Name = "daha";
            userB.UserAge = 26;


            myList1.Add(userA);
            myList1.Add(userB);

            listView1.ItemsSource = myList1;



        }
    }
}
