using Chef.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Chef.ViewModels
{
    class RecipesViewModel : DefaultViewMode
    {
        public RecipesViewModel()
        {
        }
        public ObservableCollection<Recipe> TheRecipes { get { return recipes; } }
    }
}
