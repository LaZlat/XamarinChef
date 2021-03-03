using Chef.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Chef.ViewModels
{
    class DefaultViewMode : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static ObservableCollection<Recipe> recipes = new ObservableCollection<Recipe>();

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
