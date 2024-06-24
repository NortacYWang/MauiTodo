using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTodo.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel() {

            Items = new ObservableCollection<string>();
        
        }
        [ObservableProperty]
        string text;

        [ObservableProperty]
        ObservableCollection<string> items;


        [RelayCommand]
        void Add()
        {

            if (string.IsNullOrEmpty(Text))
            {
                return;
            }
            Items.Add(Text);
            Text = string.Empty;


        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }
    }
}
