using MauiTodo.ViewModel;

namespace MauiTodo
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }


    }

}
