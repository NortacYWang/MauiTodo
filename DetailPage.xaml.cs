using MauiTodo.ViewModel;

namespace MauiTodo
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(DetailViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
