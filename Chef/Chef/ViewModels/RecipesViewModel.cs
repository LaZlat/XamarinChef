using Chef.Models;
using Chef.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Chef.ViewModels
{
    public class RecipesViewModel : DefaultViewMode
    {
        private Recipe selectedRecipe;

        public RecipesViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            //SelectCommand = new Command(async () => { await OnSelectedItem(); });
        }
        public RecipesViewModel()
        {
        }
        public ICommand SelectCommand { get; set; }
        public ObservableCollection<Recipe> TheRecipes { get { return recipes; } }
        public INavigation Navigation { get; set; }
        public Recipe SelectedRecipe
        {
            get
            {
                return selectedRecipe;
            }
            set
            {
                if (SelectedRecipe != value)
                {
                    selectedRecipe = value;
                    OnPropertyChanged("SelectedRecipe");
                    Navigation.PushAsync(new SingleRecipePage(SelectedRecipe));
                }
            }
        }
        /*public async Task OnSelectedItem()
        {
            await Navigation.PushAsync(new SingleRecipePage());
        }*/
    }
}
