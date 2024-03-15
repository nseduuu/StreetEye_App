using System.ComponentModel;

namespace Crossolution.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanging
    {
        public event System.ComponentModel.PropertyChangingEventHandler? PropertyChanging;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
