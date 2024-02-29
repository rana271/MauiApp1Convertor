using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;


namespace MauiApp1Convertor
{
    public partial class NewPage2ViewModel : ObservableObject
    {
        
        private string comments;
        private string result;
        public string Comments
        {
            get => comments;
            set => SetProperty(ref comments, value);
        }
        public string Result
        {
            get => result;
            set => SetProperty(ref result, value);
        }

        [RelayCommand]
        public void Post()
        {
            Application.Current.Dispatcher.Dispatch(() =>
            {
                Result = Comments;
            });
        }
    }
}
