using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1Convertor
{
    public class NewPageViewModel : INotifyPropertyChanged
    {
        public NewPageViewModel()
        {
            ClearCommand = new Command(() =>
            {
                Comments = string.Empty;
            });
            PostCommand = new Command(() =>
            {
                Result = Comments;
                Comments = string.Empty;
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        string _Comments;
        string _result;
        public string Comments
        {
            get => _Comments;
            set
            {
                _Comments = value;
                var args = new PropertyChangedEventArgs(nameof(Comments));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command PostCommand { get; }
        public Command ClearCommand { get; }
    }
}
